namespace Minicloner.Tests.Fakes.Inheritance
{
    public class DerivedClass_With_ProtectedInternalField : EmptyBaseClass
    {
        protected internal readonly int ProtectedInternalField;

        public DerivedClass_With_ProtectedInternalField(int value) => ProtectedInternalField = value;

        public int Get_ProtectedInternalField() => ProtectedInternalField;
    }
}