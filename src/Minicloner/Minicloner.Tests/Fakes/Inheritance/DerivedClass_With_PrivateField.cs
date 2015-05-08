using System;

namespace Minicloner.Tests.Fakes.Inheritance
{
    public class DerivedClass_With_PrivateField : BaseClass_With_PrivateField
    {
        private Int32 _privateFieldInDerivedClass;

        public void Set_PrivateField_In_DerivedClass(Int32 int32Parameter)
        {
            _privateFieldInDerivedClass = int32Parameter;
        }

        public Int32 Get_PrivateField_In_DerivedClass()
        {
            return _privateFieldInDerivedClass;
        }
    }
}