namespace Minicloner.Tests.Fakes.Inheritance
{
    public class DerivedClass_With_ProtectedField : EmptyBaseClass
    {
        protected readonly int ProtectedField;

        public DerivedClass_With_ProtectedField(int value) => ProtectedField = value;

        public int Get_ProtectedField() => ProtectedField;
    }
}