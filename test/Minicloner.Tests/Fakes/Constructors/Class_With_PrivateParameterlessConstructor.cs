using System;

namespace Minicloner.Tests.Fakes.Constructors
{
    public class Class_With_PrivateParameterlessConstructor
    {
        public Int32 PropertyInitializedInConstructor { get; private set; }
        public Int32 Int32Property { get; set; }

        private Class_With_PrivateParameterlessConstructor()
        {
            PropertyInitializedInConstructor = 1;
        }

        public static Class_With_PrivateParameterlessConstructor Create() => new Class_With_PrivateParameterlessConstructor();
    }
}