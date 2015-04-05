using System;
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
