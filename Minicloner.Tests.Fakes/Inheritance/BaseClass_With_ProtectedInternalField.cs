namespace Minicloner.Tests.Fakes.Inheritance
{
    public class BaseClass_With_ProtectedInternalField
    {
        protected internal readonly int ProtectedInternalField;

        public BaseClass_With_ProtectedInternalField(int value) => ProtectedInternalField = value;

        public int Get_ProtectedInternalField() => ProtectedInternalField;
    }
}