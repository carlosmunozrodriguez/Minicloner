namespace Minicloner.Tests.Fakes.Inheritance
{
    public class BaseClass_With_PrivateField
    {
        private int _privateFieldInBaseClass;

        public void Set_PrivateField_In_BaseClass(int int32Parameter) => _privateFieldInBaseClass = int32Parameter;

        public int Get_PrivateField_In_BaseClass() => _privateFieldInBaseClass;
    }
}