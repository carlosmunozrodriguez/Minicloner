namespace Minicloner.Tests.Fakes.Constructors
{
    public class Class_With_Two_NonParameterlessConstructors
    {
        public int Int32Property { get; }

        public Class_With_Two_NonParameterlessConstructors(int int32Parameter) => Int32Property = int32Parameter;

        public Class_With_Two_NonParameterlessConstructors(int firstInt32Parameter, int secondInt32Parameter) => Int32Property = firstInt32Parameter + secondInt32Parameter;
    }
}