#if NETSTANDARD1_0
using System;
using System.Reflection;

namespace Minicloner
{
    /// <summary>
    /// Shim class to fix the problem of not having String.Copy(string str) in netstandard1.0
    /// Based on https://github.com/dotnet/corefx/issues/7938#issuecomment-227580931
    /// </summary>
    internal static class String
    {
        private static readonly Func<string, string> CopyDelegate =
            (Func<string, string>)
                typeof(string)
                    .GetRuntimeMethod("Copy", new[] { typeof(string) })
                    .CreateDelegate(typeof(Func<string, string>));

        public static string Copy(string str) => CopyDelegate(str);
    }
}
#endif