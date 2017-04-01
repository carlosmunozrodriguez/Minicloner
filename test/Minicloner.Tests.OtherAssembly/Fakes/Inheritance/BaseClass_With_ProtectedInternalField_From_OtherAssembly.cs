namespace Minicloner.Tests.OtherAssembly.Fakes.Inheritance
{
    public class BaseClass_With_ProtectedInternalField_From_OtherAssembly
    {
        protected internal int ProtectedInternalField_In_BaseClass;

        public void Set_ProtectedInternalField_In_BaseClass(int int32Parameter)
        {
            ProtectedInternalField_In_BaseClass = int32Parameter;
        }

        public int Get_ProtectedInternalField_In_BaseClass() => ProtectedInternalField_In_BaseClass;
    }
}