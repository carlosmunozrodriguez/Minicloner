namespace Minicloner.Tests.Fakes.Constructors
{
    public class Class_With_ProtectedInternalParameterlessConstructor
    {
        public int Property { get; set; }
        public int PropertyInitializedInConstructor { get; }

        protected internal Class_With_ProtectedInternalParameterlessConstructor() => PropertyInitializedInConstructor = 1;

        public static Class_With_ProtectedInternalParameterlessConstructor Create() => new();
    }
}