namespace Minicloner.Tests.Fakes.Inheritance
{
    public class BaseClass_With_PrivateProtectedField
    {
        private protected readonly int PrivateProtectedField;

        public BaseClass_With_PrivateProtectedField(int value) => PrivateProtectedField = value;

        public int Get_PrivateProtectedField() => PrivateProtectedField;
    }
}