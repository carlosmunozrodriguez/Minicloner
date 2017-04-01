namespace Minicloner.Tests.OtherAssembly.Fakes.Fields
{
    public class Class_With_InternalField_From_OtherAssembly
    {
        internal int InternalField;

        public Class_With_InternalField_From_OtherAssembly(int parameter)
        {
            InternalField = parameter;
        }

        public int Get_InternalField() => InternalField;
    }
}