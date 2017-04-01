namespace Minicloner.Tests.Fakes.Inheritance
{
    public class BaseClass_With_ProtectedField
    {
        protected int ProtectedField_In_BaseClass;

        public void Set_ProtectedField_In_BaseClass(int int32Parameter) => ProtectedField_In_BaseClass = int32Parameter;

        public int Get_ProtectedField_In_BaseClass() => ProtectedField_In_BaseClass;
    }
}