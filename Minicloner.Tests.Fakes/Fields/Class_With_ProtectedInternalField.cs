namespace Minicloner.Tests.Fakes.Fields
{
    public class Class_With_ProtectedInternalField
    {
        protected internal readonly int ProtectedInternalField;

        public Class_With_ProtectedInternalField(int value) => ProtectedInternalField = value;

        public int Get_ProtectedInternalField() => ProtectedInternalField;
    }
}