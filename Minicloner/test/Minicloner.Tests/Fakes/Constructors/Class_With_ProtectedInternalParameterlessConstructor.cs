using System;

namespace Minicloner.Tests.Fakes.Constructors
{
    public class Class_With_ProtectedInternalParameterlessConstructor
    {
        public Int32 Int32Property { get; set; }
        public Int32 PropertyInitializedInConstructor { get; private set; }

        protected internal Class_With_ProtectedInternalParameterlessConstructor()
        {
            PropertyInitializedInConstructor = 1;
        }
    }
}