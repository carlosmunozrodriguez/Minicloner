using System;

namespace Minicloner.Tests.Fakes.Constructors
{
    public class Class_With_ProtectedParameterlessConstructor
    {
        public Int32 Int32Property { get; set; }
        public Int32 PropertyInitializedInConstructor { get; private set; }

        protected Class_With_ProtectedParameterlessConstructor()
        {
            PropertyInitializedInConstructor = 1;
        }

        public static Class_With_ProtectedParameterlessConstructor Create()
        {
            return new Class_With_ProtectedParameterlessConstructor();
        }
    }
}