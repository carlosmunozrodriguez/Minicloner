using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
#if NET45
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
                    case object alreadyCloned when _clonedInstances.ContainsKey(alreadyCloned):
                        return _clonedInstances[alreadyCloned];
                    case string @string: return CloneString(@string);
                    case Array array: return CloneArray(array);
                    default:
                        return @object.GetType()
#if NETSTANDARD1_0
                            .GetTypeInfo()
#endif
                            .IsValueType ? @object : CloneReferenceType(@object);
                }

                // Use native String.Copy so string is not interned.
                object CloneString(string @string) => _clonedInstances[@string] = String.Copy(@string);

                object CloneArray(Array array)
                {
                    var rank = array.Rank;
                    var lengths = new int[rank];
                    var lowerBounds = new int[rank];
                    for (var i = 0; i < rank; i++)
                    {
                        lengths[i] = array.GetLength(i);
                        lowerBounds[i] = array.GetLowerBound(i);
                    }

                    var clone =
                        (Array)(_clonedInstances[array] =
                            Array.CreateInstance(array.GetType().GetElementType(), lengths, lowerBounds));

                    foreach (var indices in
                        // This code generates a list of all coordinates in the n-dimensional array
                        // so it can be traversed by a 1-dimensional foreach
                        lengths
                        .Select((length, rankIndex) => Enumerable.Range(lowerBounds[rankIndex], length))
                        .Aggregate<IEnumerable<int>, IEnumerable<IEnumerable<int>>>(
                            new[] { new int[0] },
                            (accumulatedCartesianProduct, rightSideOfCartesianProduct) =>
                                from partialIndicesList in accumulatedCartesianProduct
                                from nextIndex in rightSideOfCartesianProduct
                                select partialIndicesList.Concat(new[] { nextIndex }))
                        .Select(indices => indices.ToArray()))
                    {
                        clone.SetValue(CloneObject(array.GetValue(indices)), indices);
                    }

                    return clone;
                }

                object CloneReferenceType(object referenceTypeObject)
                {
                    var type = referenceTypeObject.GetType();
                    var clone = _clonedInstances[referenceTypeObject] = FormatterServices.GetUninitializedObject(type);

                    while (type != null)
                    {
                        foreach (var fieldInfo in type
                            .GetRuntimeFields()
                            .Where(
                                x => !x.IsStatic &&     // All instances should already share the same value.
                                x.DeclaringType == type // Don't clone parent class fields yet
                            )
                        )
                        {
                            fieldInfo.SetValue(clone, CloneObject(fieldInfo.GetValue(referenceTypeObject)));
                        }

                        type = type
#if NETSTANDARD1_0
                            .GetTypeInfo()
#endif
                            .BaseType;
                    }

                    return clone;
                }
            }
        }
    }
}