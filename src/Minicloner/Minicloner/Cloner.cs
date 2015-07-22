using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace Minicloner
{
    public class Cloner : ICloner
    {
        private readonly Dictionary<object, object> _clonedInstances = new Dictionary<object, object>();

        public T Clone<T>(T source)
        {
            return (T)CloneObject(source);
        }

        private object CloneObject(object source)
        {
            if (source == null)
            {
                return null;
            }

            if (_clonedInstances.ContainsKey(source))
            {
                return _clonedInstances[source];
            }

            var @string = source as string;
            if (@string != null)
            {
                return CloneString(@string);
            }

            var array = source as Array;
            if (array != null)
            {
                return CloneArray(array);
            }

            return source.GetType().IsValueType ? CloneValueType(source) : CloneReferenceType(source);
        }

        private object CloneString(string @string)
        {
            // We really mean cloning here so if source is string use native String.Copy so string is not interned.
            // TODO: Add an optional options object to Cloner's constructor to allow for optional string interning among other things.
            return _clonedInstances[@string] = String.Copy(@string);
        }

        private object CloneArray(Array array)
        {
            // TODO: Find out if the cloned instance is really a clone or differs in something from the original array

            // Unoptimized
            //var lengths = Enumerable.Range(0, array.Rank)
            //    .Select(x => array.GetLength(x));

            var rank = array.Rank;
            var lengths = new List<int>(rank);
            var lowerBounds = new List<int>(rank);
            for (var i = 0; i < rank; i++)
            {
                lengths.Add(array.GetLength(i));
                lowerBounds.Add(array.GetLowerBound(i));
            }

            var newArray = (Array)(_clonedInstances[array] = Array.CreateInstance(array.GetType().GetElementType(), lengths.ToArray(), lowerBounds.ToArray()));

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

        private static object CloneValueType(object source)
        {
            return source;
        }

        private object CloneReferenceType(object source)
        {
            var type = source.GetType();
            var cloned = _clonedInstances[source] = FormatterServices.GetUninitializedObject(type);

            // TODO: Allow circular references
            while (type != null)
            {
                foreach (var fieldInfo in type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly))
                {
                    fieldInfo.SetValue(cloned, CloneObject(fieldInfo.GetValue(source)));
                }

                type = type.BaseType;
            }

            return cloned;
        }
    }
}