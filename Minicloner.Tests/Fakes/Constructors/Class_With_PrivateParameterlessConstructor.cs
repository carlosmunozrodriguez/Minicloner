namespace Minicloner.Tests.Fakes.Constructors
{
    public class Class_With_PrivateParameterlessConstructor
    {
        public int PropertyInitializedInConstructor { get; }
        public int Int32Property { get; set; }

        private Class_With_PrivateParameterlessConstructor() => PropertyInitializedInConstructor = 1;

        public static Class_With_PrivateParameterlessConstructor Create() => new Class_With_PrivateParameterlessConstructor();
    }
}