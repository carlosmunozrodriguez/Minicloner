namespace Minicloner.Tests.Fakes.Constructors
{
    public class Class_With_OneParameterConstructor_And_ParameterlessContructor
    {
        public int Int32Property { get; private set; }

        public Class_With_OneParameterConstructor_And_ParameterlessContructor(int int32Parameter)
        {
            Int32Property = int32Parameter;
        }

        public Class_With_OneParameterConstructor_And_ParameterlessContructor()
        {
            Int32Property = 2;
        }
    }
}