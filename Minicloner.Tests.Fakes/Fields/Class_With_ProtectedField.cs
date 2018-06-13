namespace Minicloner.Tests.Fakes.Fields
{
    public class Class_With_ProtectedField
    {
        protected readonly int ProtectedField;

        public Class_With_ProtectedField(int value) => ProtectedField = value;

        public int Get_ProtectedField() => ProtectedField;
    }
}