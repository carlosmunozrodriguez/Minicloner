namespace Minicloner.Tests.OtherAssembly.Fakes.Inheritance
{
    public class DerivedClass_With_ProtectedInternalField_From_OtherAssembly : BaseClass_With_ProtectedInternalField_From_OtherAssembly
    {
        protected internal int ProtectedInternalField_In_DerivedClass;

        public void Set_ProtectedInternalField_In_DerivedClass(int int32Parameter) => ProtectedInternalField_In_DerivedClass = int32Parameter;

        public int Get_ProtectedInternalField_In_DerivedClass() => ProtectedInternalField_In_DerivedClass;
    }
}