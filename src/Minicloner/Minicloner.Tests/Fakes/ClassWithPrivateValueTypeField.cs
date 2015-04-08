using System;

namespace Minicloner.Tests.Fakes
{
    public class ClassWithPrivateValueTypeField
    {
        private readonly Int32 _publicInt32Field;

        public ClassWithPrivateValueTypeField(Int32 int32Parameter)
        {
            _publicInt32Field = int32Parameter;
        }

        public Int32 GetPrivateFieldValue()
        {
            return _publicInt32Field;
        }
    }
}