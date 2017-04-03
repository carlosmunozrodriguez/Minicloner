namespace Minicloner.Tests.OtherAssembly.Fakes.Fields
{
    public class Class_With_ProtectedInternalField_From_OtherAssembly
    {
        protected internal int ProtectedInternalField;

        public Class_With_ProtectedInternalField_From_OtherAssembly(int parameter) => ProtectedInternalField = parameter;

        public int Get_ProtectedInternalField() => ProtectedInternalField;
    }
}