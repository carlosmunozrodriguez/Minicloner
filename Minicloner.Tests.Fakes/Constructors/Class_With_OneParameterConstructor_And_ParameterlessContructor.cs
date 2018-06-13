namespace Minicloner.Tests.Fakes.Constructors
{
    public class Class_With_OneParameterConstructor_And_ParameterlessContructor
    {
        public int Property { get; }

        public Class_With_OneParameterConstructor_And_ParameterlessContructor(int value) => Property = value;

        public Class_With_OneParameterConstructor_And_ParameterlessContructor() => Property = 2;
    }
}