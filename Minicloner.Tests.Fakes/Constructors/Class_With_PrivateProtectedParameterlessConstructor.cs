namespace Minicloner.Tests.Fakes.Constructors
{
    public class Class_With_PrivateProtectedParameterlessConstructor
    {
        public int Property { get; set; }
        public int PropertyInitializedInConstructor { get; }

        private protected Class_With_PrivateProtectedParameterlessConstructor() => PropertyInitializedInConstructor = 1;

        public static Class_With_PrivateProtectedParameterlessConstructor Create() => new Class_With_PrivateProtectedParameterlessConstructor();
    }
}