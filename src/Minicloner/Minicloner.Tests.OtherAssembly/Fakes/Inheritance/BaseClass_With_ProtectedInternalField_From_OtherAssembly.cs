using System;

namespace Minicloner.Tests.OtherAssembly.Fakes.Inheritance
{
    public class BaseClass_With_ProtectedInternalField_From_OtherAssembly
    {
        protected internal Int32 ProtectedInternalField_In_BaseClass;

        public void Set_ProtectedInternalField_In_BaseClass(Int32 int32Parameter)
        {
            ProtectedInternalField_In_BaseClass = int32Parameter;
        }

        public Int32 Get_ProtectedInternalField_In_BaseClass()
        {
            return ProtectedInternalField_In_BaseClass;
        }
    }
}