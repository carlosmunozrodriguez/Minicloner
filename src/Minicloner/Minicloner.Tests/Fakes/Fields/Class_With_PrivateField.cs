using System;

namespace Minicloner.Tests.Fakes.Fields
{
    public class Class_With_PrivateField
    {
        private readonly Int32 _privateField;

        public Class_With_PrivateField(Int32 parameter)
        {
            _privateField = parameter;
        }

        public Int32 Get_PrivateField()
        {
            return _privateField;
        }
    }
}