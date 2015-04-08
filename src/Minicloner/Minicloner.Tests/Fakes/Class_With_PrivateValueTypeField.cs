using System;

namespace Minicloner.Tests.Fakes
{
    public class Class_With_PrivateValueTypeField
    {
        private readonly Int32 _privateInt32Field;

        public Class_With_PrivateValueTypeField(Int32 int32Parameter)
        {
            _privateInt32Field = int32Parameter;
        }

        public Int32 Get_PrivateValueTypeField()
        {
            return _privateInt32Field;
        }
    }
}