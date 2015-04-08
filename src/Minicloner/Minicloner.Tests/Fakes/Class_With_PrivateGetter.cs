using System;

namespace Minicloner.Tests.Fakes
{
    public class Class_With_PrivateGetter
    {
        public Int32 Int32Property_With_PrivateGetter { private get; set; }

        public Int32 Get_Int32Property_With_PrivateGetter()
        {
            return Int32Property_With_PrivateGetter;
        }
    }
}