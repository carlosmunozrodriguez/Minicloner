using System;

namespace Minicloner.Tests.Fakes.Constructors
{
    public class Class_With_Two_NonParameterlessConstructors
    {
        public int Int32Property { get; private set; }

        public Class_With_Two_NonParameterlessConstructors(Int32 int32Parameter)
        {
            Int32Property = int32Parameter;
        }

        public Class_With_Two_NonParameterlessConstructors(Int32 firstInt32Parameter, Int32 secondInt32Parameter)
        {
            Int32Property = firstInt32Parameter + secondInt32Parameter;
        }
    }
}