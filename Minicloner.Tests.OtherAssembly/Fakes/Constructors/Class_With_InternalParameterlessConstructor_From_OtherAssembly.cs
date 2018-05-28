namespace Minicloner.Tests.OtherAssembly.Fakes.Constructors
{
    public class Class_With_InternalParameterlessConstructor_From_OtherAssembly
    {
        public int Int32Property { get; set; }
        public int PropertyInitializedInConstructor { get; }

        internal Class_With_InternalParameterlessConstructor_From_OtherAssembly() => PropertyInitializedInConstructor = 1;

        public static Class_With_InternalParameterlessConstructor_From_OtherAssembly Create() => new Class_With_InternalParameterlessConstructor_From_OtherAssembly();
    }
}