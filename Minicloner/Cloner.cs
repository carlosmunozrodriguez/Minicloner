using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
#if !NETSTANDARD1_0
using System.Runtime.Serialization;
#endif

namespace Minicloner
{
    public class Cloner : ICloner
    {
        private readonly Dictionary<object, object> _clonedInstances = new();

        public T Clone<T>(T source) => (T)CloneObject(source);

        private object CloneObject(object @object) =>
            @object switch
            {
                null => null,
                var alreadyCloned when _clonedInstances.ContainsKey(alreadyCloned) => _clonedInstances[alreadyCloned],
                string @string => CloneString(@string),
                Array array => CloneArray(array),
                _ => @object.GetType()
#if NETSTANDARD1_0
                    .GetTypeInfo()
#endif
                    .IsValueType
                    ? CloneValueType(@object)
                    : CloneReferenceType(@object)
            };

        // Use native String.Copy so string is not interned.
        private object CloneString(string @string) => _clonedInstances[@string] = String.Copy(@string);

        private object CloneArray(Array array)
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
                    Array.CreateInstance(array.GetType().GetElementType()!, lengths, lowerBounds));

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

        private object CloneValueType(object valueTypeObject)
        {
            var type = valueTypeObject.GetType();

            if (type
#if NETSTANDARD1_0
                    .GetTypeInfo()
#endif
                    .IsPrimitive)
            {
                return valueTypeObject;
            }

            var clone = _clonedInstances[valueTypeObject] = FormatterServices.GetUninitializedObject(type);

            // We don't need to iterate the hierarchy of value types since structs can't inherit from other class/struct

            SetFields(valueTypeObject, type, clone);

            return clone;
        }

        private object CloneReferenceType(object referenceTypeObject)
        {
            var type = referenceTypeObject.GetType();
            var clone = _clonedInstances[referenceTypeObject] = FormatterServices.GetUninitializedObject(type);

            while (type is not null)
            {
                SetFields(referenceTypeObject, type, clone);

                type = type
#if NETSTANDARD1_0
                    .GetTypeInfo()
#endif
                    .BaseType;
            }

            return clone;
        }

        private void SetFields(object originalObject, Type type, object clone)
        {
            foreach (var fieldInfo in type
                .GetRuntimeFields()
                .Where(x =>
                    !x.IsStatic && // All instances should already share the same value.
                    x.DeclaringType == type // Don't clone parent class fields yet
                )
            )
            {
                fieldInfo.SetValue(clone, CloneObject(fieldInfo.GetValue(originalObject)));
            }
        }
    }
}