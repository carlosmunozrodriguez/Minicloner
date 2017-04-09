#if !NET462
using System;
using System.Reflection;

namespace Minicloner
{
    /// <summary>
    /// Hack to fix the problem of not having FormatterServices class in netstandard1.6
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
                    .GetTypeInfo()
                    .GetMethod("GetUninitializedObject", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static)
                    .CreateDelegate(typeof(Func<Type, object>));

        public static object GetUninitializedObject(Type type) => GetUninitializedObjectDelegate(type);
    }
}
#endif