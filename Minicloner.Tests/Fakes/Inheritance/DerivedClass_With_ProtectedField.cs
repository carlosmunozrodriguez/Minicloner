namespace Minicloner.Tests.Fakes.Inheritance
{
    public class DerivedClass_With_ProtectedField : BaseClass_With_ProtectedField
    {
        protected int ProtectedField_In_DerivedClass;

        public void Set_ProtectedField_In_DerivedClass(int int32Parameter) => ProtectedField_In_DerivedClass = int32Parameter;

        public int Get_ProtectedField_In_DerivedClass() => ProtectedField_In_DerivedClass;
    }
}