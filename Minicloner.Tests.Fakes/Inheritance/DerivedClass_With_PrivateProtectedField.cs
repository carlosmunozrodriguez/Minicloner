namespace Minicloner.Tests.Fakes.Inheritance
{
    public class DerivedClass_With_PrivateProtectedField : EmptyBaseClass
    {
        private protected readonly int PrivateProtectedField;

        public DerivedClass_With_PrivateProtectedField(int value) => PrivateProtectedField = value;

        public int Get_PrivateProtectedField() => PrivateProtectedField;
    }
}