namespace Minicloner.Tests.Fakes.Constructors
{
    public class Class_With_ProtectedInternalParameterlessConstructor
    {
        public int Int32Property { get; set; }
        public int PropertyInitializedInConstructor { get; }

        protected internal Class_With_ProtectedInternalParameterlessConstructor() => PropertyInitializedInConstructor = 1;
    }
}