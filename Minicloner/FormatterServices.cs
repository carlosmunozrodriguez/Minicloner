#if NETSTANDARD1_0
using System;
using System.Reflection;

namespace Minicloner
{
    /// <summary>
    /// Shim class to fix the problem of not having FormatterServices class in netstandard
    /// Based on https://github.com/dotnet/corefx/issues/7938#issuecomment-227580931
    /// </summary>
    internal static class FormatterServices
    {
        private static readonly Func<Type, object> GetUninitializedObjectDelegate =
            (Func<Type, object>)
                typeof(string) // String or other type that belongs to mscorlib assembly
                    .GetTypeInfo()
                    .Assembly
                    .GetType("System.Runtime.Serialization.FormatterServices")
                    .GetRuntimeMethod("GetUninitializedObject", new[] { typeof(Type) })
                    .CreateDelegate(typeof(Func<Type, object>));

        public static object GetUninitializedObject(Type type) => GetUninitializedObjectDelegate(type);
    }
}
#endif