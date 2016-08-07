using System;

namespace Minicloner.Tests.Fakes.Inheritance
{
    public class DerivedClass_With_ProtectedField : BaseClass_With_ProtectedField
    {
        protected Int32 ProtectedField_In_DerivedClass;

        public void Set_ProtectedField_In_DerivedClass(Int32 int32Parameter) => ProtectedField_In_DerivedClass = int32Parameter;

        public Int32 Get_ProtectedField_In_DerivedClass() => ProtectedField_In_DerivedClass;
    }
}