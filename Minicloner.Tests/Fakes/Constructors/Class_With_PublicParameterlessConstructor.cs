namespace Minicloner.Tests.Fakes.Constructors
{
    public class Class_With_PublicParameterlessConstructor
    {
        public int PropertyInitializedInConstructor { get; }
        public int Int32Property { get; set; }

        public Class_With_PublicParameterlessConstructor() => PropertyInitializedInConstructor = 1;
    }
}