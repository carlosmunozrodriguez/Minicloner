using System;

namespace Minicloner.Tests.Fakes.Constructors
{
    public class Class_With_PublicParameterlessConstructor
    {
        public Int32 PropertyInitializedInConstructor { get; private set; }
        public Int32 Int32Property { get; set; }

        public Class_With_PublicParameterlessConstructor()
        {
            PropertyInitializedInConstructor = 1;
        }
    }
}