namespace Minicloner.Tests.Fakes.Constructors
{
    public class Class_With_ProtectedParameterlessConstructor
    {
        public int Property { get; set; }
        public int PropertyInitializedInConstructor { get; }

        protected Class_With_ProtectedParameterlessConstructor() => PropertyInitializedInConstructor = 1;

        public static Class_With_ProtectedParameterlessConstructor Create() => new Class_With_ProtectedParameterlessConstructor();
    }
}