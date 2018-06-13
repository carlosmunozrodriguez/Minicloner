namespace Minicloner.Tests.Fakes.Constructors
{
    public class Class_With_PublicParameterlessConstructor
    {
        public int Property { get; set; }
        public int PropertyInitializedInConstructor { get; }

        public Class_With_PublicParameterlessConstructor() => PropertyInitializedInConstructor = 1;
    }
}