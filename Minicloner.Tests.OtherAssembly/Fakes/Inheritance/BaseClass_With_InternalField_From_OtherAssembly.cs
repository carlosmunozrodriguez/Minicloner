namespace Minicloner.Tests.OtherAssembly.Fakes.Inheritance
{
    public class BaseClass_With_InternalField_From_OtherAssembly
    {
        internal int InternalField_In_BaseClass;

        public void Set_InternalField_In_BaseClass(int int32Parameter) => InternalField_In_BaseClass = int32Parameter;

        public int Get_InternalField_In_BaseClass() => InternalField_In_BaseClass;
    }
}