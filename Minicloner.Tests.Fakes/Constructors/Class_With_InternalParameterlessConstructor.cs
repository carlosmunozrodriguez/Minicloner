namespace Minicloner.Tests.Fakes.Constructors
{
    public class Class_With_InternalParameterlessConstructor
    {
        public int Property { get; set; }
        public int PropertyInitializedInConstructor { get; }

        internal Class_With_InternalParameterlessConstructor() => PropertyInitializedInConstructor = 1;

        public static Class_With_InternalParameterlessConstructor Create() => new();
    }
}