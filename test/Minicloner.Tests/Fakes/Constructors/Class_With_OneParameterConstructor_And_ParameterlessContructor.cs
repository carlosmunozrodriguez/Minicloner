using System;

namespace Minicloner.Tests.Fakes.Constructors
{
    public class Class_With_OneParameterConstructor_And_ParameterlessContructor
    {
        public Int32 Int32Property { get; private set; }

        public Class_With_OneParameterConstructor_And_ParameterlessContructor(Int32 int32Parameter)
        {
            Int32Property = int32Parameter;
        }

        public Class_With_OneParameterConstructor_And_ParameterlessContructor()
        {
            Int32Property = 2;
        }
    }
}