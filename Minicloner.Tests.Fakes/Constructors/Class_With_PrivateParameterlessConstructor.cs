namespace Minicloner.Tests.Fakes.Constructors
{
    public class Class_With_PrivateParameterlessConstructor
    {
        public int Property { get; set; }
        public int PropertyInitializedInConstructor { get; }

        private Class_With_PrivateParameterlessConstructor() => PropertyInitializedInConstructor = 1;

        public static Class_With_PrivateParameterlessConstructor Create() => new();
    }
}