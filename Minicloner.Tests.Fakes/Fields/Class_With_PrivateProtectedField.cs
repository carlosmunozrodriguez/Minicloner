namespace Minicloner.Tests.Fakes.Fields
{
    public class Class_With_PrivateProtectedField
    {
        private protected readonly int PrivateProtectedField;

        public Class_With_PrivateProtectedField(int value) => PrivateProtectedField = value;

        public int Get_PrivateProtectedField() => PrivateProtectedField;
    }
}