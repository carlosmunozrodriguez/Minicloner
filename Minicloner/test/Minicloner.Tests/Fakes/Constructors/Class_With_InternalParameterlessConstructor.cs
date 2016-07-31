using System;

namespace Minicloner.Tests.Fakes.Constructors
{
    public class Class_With_InternalParameterlessConstructor
    {
        public Int32 Int32Property { get; set; }
        public Int32 PropertyInitializedInConstructor { get; private set; }

        internal Class_With_InternalParameterlessConstructor()
        {
            PropertyInitializedInConstructor = 1;
        }
    }
}