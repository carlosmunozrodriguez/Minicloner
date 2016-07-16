using System;

namespace Minicloner.Tests.Fakes.Properties
{
    public class Class_With_PrivateGetter
    {
        public Int32 Int32Property_With_PrivateGetter { private get; set; }

        public Int32 Get_Int32Property_With_PrivateGetter() => Int32Property_With_PrivateGetter;
    }
}