namespace Minicloner.Tests.Fakes.Constructors
{
    public class Class_With_Two_NonParameterlessConstructors
    {
        public int Property { get; }

        public Class_With_Two_NonParameterlessConstructors(int value) => Property = value;

        public Class_With_Two_NonParameterlessConstructors(int firstValue, int secondValue) => Property = firstValue + secondValue;
    }
}