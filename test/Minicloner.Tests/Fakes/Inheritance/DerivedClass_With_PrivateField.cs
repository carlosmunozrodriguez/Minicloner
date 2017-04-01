namespace Minicloner.Tests.Fakes.Inheritance
{
    public class DerivedClass_With_PrivateField : BaseClass_With_PrivateField
    {
        private int _privateFieldInDerivedClass;

        public void Set_PrivateField_In_DerivedClass(int int32Parameter) => _privateFieldInDerivedClass = int32Parameter;

        public int Get_PrivateField_In_DerivedClass() => _privateFieldInDerivedClass;
    }
}