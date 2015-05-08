using System;

namespace Minicloner.Tests.Fakes.Inheritance
{
    public class BaseClass_With_PrivateField
    {
        private Int32 _privateFieldInBaseClass;

        public void Set_PrivateField_In_BaseClass(Int32 int32Parameter)
        {
            _privateFieldInBaseClass = int32Parameter;
        }

        public Int32 Get_PrivateField_In_BaseClass()
        {
            return _privateFieldInBaseClass;
        }
    }
}