namespace Minicloner.Tests.OtherAssembly.Fakes.Inheritance
{
    public class DerivedClass_With_InternalField_From_OtherAssembly : BaseClass_With_InternalField_From_OtherAssembly
    {
        internal int InternalField_In_DerivedClass;

        public void Set_InternalField_In_DerivedClass(int int32Parameter) => InternalField_In_DerivedClass = int32Parameter;

        public int Get_InternalField_In_DerivedClass() => InternalField_In_DerivedClass;
    }
}