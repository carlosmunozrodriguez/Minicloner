namespace Minicloner.Tests.Fakes.Constructors
{
    public class Class_With_OneParameterConstructor
    {
        public int Int32Property { get; }

        public Class_With_OneParameterConstructor(int int32Parameter) => Int32Property = int32Parameter;
    }
}