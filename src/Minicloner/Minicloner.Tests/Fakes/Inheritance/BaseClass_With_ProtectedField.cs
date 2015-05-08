using System;

namespace Minicloner.Tests.Fakes.Inheritance
{
    public class BaseClass_With_ProtectedField
    {
        protected Int32 ProtectedField_In_BaseClass;

        public void Set_ProtectedField_In_BaseClass(Int32 int32Parameter)
        {
            ProtectedField_In_BaseClass = int32Parameter;
        }

        public Int32 Get_ProtectedField_In_BaseClass()
        {
            return ProtectedField_In_BaseClass;
        }
    }
}