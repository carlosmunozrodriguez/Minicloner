using System;

namespace Minicloner.Tests.Fakes
{
    public class Class_With_PrivateSetter
    {
        public Int32 Int32Property_With_PrivateSetter { get; private set; }

        public void Set_Int32Property_With_PrivateSetter(Int32 int32Parameter)
        {
            Int32Property_With_PrivateSetter = int32Parameter;
        }
    }
}