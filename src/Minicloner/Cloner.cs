using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
#if NET462
using System.Runtime.Serialization;
#endif

namespace Minicloner
{
    public class Cloner : ICloner
    {
        private readonly Dictionary<object, object> _clonedInstances = new Dictionary<object, object>();

        public T Clone<T>(T source)
        {
            return (T)CloneObject(source);

            object CloneObject(object @object)
            {
                switch (@object)
                {
                    case null: return null;
                    case object alreadyCloned when _clonedInstances.ContainsKey(alreadyCloned): return _clonedInstances[alreadyCloned];
                    case string @string: return CloneString(@string);
                    case Array array: return CloneArray(array);
                    default: return @object.GetType().GetTypeInfo().IsValueType ? @object : CloneReferenceType(@object);
                }

                // We really mean cloning here so if @object is string use native String.Copy so string is not interned.
                // TODO: Add an optional options object to Cloner's constructor to allow for optional string interning among other things.
                object CloneString(string @string) =>
#if NET462
                    _clonedInstances[@string] = string.Copy(@string);
#else
                    _clonedInstances[@string] = @string.Copy();
#endif

                object CloneArray(Array array)
                {
                    // TODO: Find out if the cloned instance is really a clone or differs in something from the original array
                    var rank = array.Rank;
                    var lengths = new int[rank];
                    var lowerBounds = new int[rank];
                    for (var i = 0; i < rank; i++)
                    {
                        lengths[i] = array.GetLength(i);
                        lowerBounds[i] = array.GetLowerBound(i);
                    }

                    var newArray = (Array)(_clonedInstances[array] = Array.CreateInstance(array.GetType().GetElementType(), lengths, lowerBounds));

                    foreach (var indices in lengths
                        .Select((length, rankIndex) => Enumerable.Range(lowerBounds[rankIndex], length))
                        .Aggregate<IEnumerable<int>, IEnumerable<IEnumerable<int>>>(
                            new List<List<int>> { new List<int>() },
                            (accumulatedCartesianProduct, rightSideOfCartesianProduct) =>
                                from partialIndicesList in accumulatedCartesianProduct
                                from nextIndex in rightSideOfCartesianProduct
                                select partialIndicesList.Concat(new[] { nextIndex }))
                        .Select(indices => indices.ToArray()))
                    {
                        newArray.SetValue(CloneObject(array.GetValue(indices)), indices);
                    }

                    return newArray;
                }

                object CloneReferenceType(object referenceTypeObject)
                {
                    var type = referenceTypeObject.GetType();
                    var cloned = _clonedInstances[referenceTypeObject] = FormatterServices.GetUninitializedObject(type);

                    while (type != null)
                    {
                        foreach (var fieldInfo in type.GetTypeInfo().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly))
                        {
                            fieldInfo.SetValue(cloned, CloneObject(fieldInfo.GetValue(referenceTypeObject)));
                        }

                        type = type.GetTypeInfo().BaseType;
                    }

                    return cloned;
                }
            }
        }
    }
}