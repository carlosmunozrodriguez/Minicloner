namespace Minicloner.Tests.Fakes.Constructors
{
    public class Class_With_OneParameterConstructor
    {
        public int Int32Property { get; private set; }

        public Class_With_OneParameterConstructor(int int32Parameter) => Int32Property = int32Parameter;
    }
}