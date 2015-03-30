using System;
using System.Runtime.Serialization;

namespace Minicloner
{
    public class Cloner : ICloner
    {
        public T Clone<T>(T source)
        {
            if (source == null || source.GetType().IsValueType)
            {
                return source;
            }

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

            var cloned = FormatterServices.GetUninitializedObject(source.GetType());

            // TODO: Copy fields, and property values to cloned object
            // TODO: Deep clone recursively
            // TODO: Allow circular references

            return cloned;
        }
    }
}
