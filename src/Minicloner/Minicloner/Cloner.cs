using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace Minicloner
{
    public class Cloner : ICloner
    {
        public T Clone<T>(T source)
        {
            return (T)CloneObject(source);
        }

        private static object CloneObject(object source)
        {
            if (source == null)
            {
                return null;
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

        private static object CloneString(string @string)
        {
            // We really mean cloning here so if source is string use native String.Copy so string is not interned.
            // TODO: Add an optional options object to Cloner's constructor to allow for optional string interning among other things.

            return String.Copy(@string);
        }

        private static object CloneArray(Array array)
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

            var newArray = Array.CreateInstance(array.GetType().GetElementType(), lengths.ToArray(), lowerBounds.ToArray());

            IEnumerable<IEnumerable<int>> listWithEmptyListOfIndices = new List<List<int>> { new List<int>() };
            var indicesList = lengths
                .Select((length, rankIndex) => Enumerable.Range(lowerBounds[rankIndex], length))
                .Aggregate(
                    listWithEmptyListOfIndices,
                    (accumulatedCartesianProduct, rightSideOfCartesianProduct) =>
                        from partialIndicesList in accumulatedCartesianProduct
                        from nextIndex in rightSideOfCartesianProduct
                        select partialIndicesList.Concat(new[] { nextIndex }))
                .Select(indices => indices.ToArray());

            foreach (var indices in indicesList)
            {
                newArray.SetValue(CloneObject(array.GetValue(indices)), indices);
            }

            return newArray;
        }

        private static object CloneValueType(object source)
        {
            return source;
        }

        private static object CloneReferenceType(object source)
        {
            var type = source.GetType();
            var cloned = FormatterServices.GetUninitializedObject(type);

            // TODO: Allow circular references
            foreach (var fieldInfo in type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
            {
                fieldInfo.SetValue(cloned, CloneObject(fieldInfo.GetValue(source)));
            }

            return cloned;
        }
    }
}
