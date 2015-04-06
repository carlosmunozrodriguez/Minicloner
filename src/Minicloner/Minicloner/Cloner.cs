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
            #region This code seems to be redundant
            //if (source == null || source.GetType().IsValueType)
            //{
            //    return source;
            //}
            #endregion

            return (T)CloneRefenceType(source);
        }

        private object CloneRefenceType(object source)
        {
            if (source == null)
            {
                return null;
            }

            // We really mean cloning here so if source is string use native String.Copy so string is not interned.
            // TODO: Add an optional options object to Cloner's constructor to allow for optional string interning.
            var s = source as string;
            if (s != null)
            {
                return String.Copy(s);
            }

            var type = source.GetType();

            // TODO: Find out if the cloned instance is really a clone or differs in something from the original array
            var array = source as Array;
            if (array != null)
            {
                // Unoptimized
                //var lengths = Enumerable.Range(0, array.Rank)
                //    .Select(x => array.GetLength(x));

                var lengths = new List<int>(array.Rank);
                for (var i = 0; i < array.Rank; i++)
                {
                    lengths.Add(array.GetLength(i));
                }

                var newArray = Array.CreateInstance(type.GetElementType(), lengths.ToArray());

                IEnumerable<IEnumerable<int>> listWithEmptyListOfIndices = new List<List<int>> { new List<int>() };
                var indicesList = lengths
                    .Select(length => Enumerable.Range(0, length))
                    .Aggregate(
                        listWithEmptyListOfIndices,
                        (accumulatedCartesianProduct, rightSideOfCartesianProduct) => from partialIndicesList in accumulatedCartesianProduct
                                                                                      from nextIndex in rightSideOfCartesianProduct
                                                                                      select partialIndicesList.Concat(new[] { nextIndex }))
                    .Select(indices => indices.ToArray());

                foreach (var indices in indicesList)
                {
                    newArray.SetValue(array.GetValue(indices), indices);
                }

                return newArray;
            }

            var cloned = FormatterServices.GetUninitializedObject(type);

            // TODO: Clone property values to cloned object
            // TODO: Deep clone recursively
            // TODO: Allow circular references

            foreach (var fieldInfo in type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
            {
                fieldInfo.SetValue(cloned, fieldInfo.GetValue(source));
            }

            return cloned;
        }
    }
}
