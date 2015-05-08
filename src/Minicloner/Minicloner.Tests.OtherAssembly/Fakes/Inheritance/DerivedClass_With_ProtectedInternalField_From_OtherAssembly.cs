using System;

namespace Minicloner.Tests.OtherAssembly.Fakes.Inheritance
{
    public class DerivedClass_With_ProtectedInternalField_From_OtherAssembly : BaseClass_With_ProtectedInternalField_From_OtherAssembly
    {
        protected internal Int32 ProtectedInternalField_In_DerivedClass;

        public void Set_ProtectedInternalField_In_DerivedClass(Int32 int32Parameter)
        {
            ProtectedInternalField_In_DerivedClass = int32Parameter;
        }

        public Int32 Get_ProtectedInternalField_In_DerivedClass()
        {
            return ProtectedInternalField_In_DerivedClass;
        }
    }
}