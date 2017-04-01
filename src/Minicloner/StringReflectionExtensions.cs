using System;
using System.Reflection;

namespace Minicloner
{
    /// <summary>
    /// Hack class to fix the problem of not having String.Copy(string str) in netstandard1.6
    /// Based on https://github.com/dotnet/corefx/issues/7938#issuecomment-227580931
    /// </summary>
    internal static class StringReflectionExtensions
    {
        private static readonly Func<string, string> CopyDelegate =
            (Func<string, string>)
                typeof(string)
                    .GetTypeInfo()
                    .Assembly
                    .GetType("System.String")
                    .GetMethod("Copy", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static)
                    .CreateDelegate(typeof(Func<string, string>));

        public static string Copy(this string str) => CopyDelegate(str);
    }
}