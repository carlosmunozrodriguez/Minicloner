namespace Minicloner.Tests.Fakes.Inheritance
{
    public class BaseClass_With_ProtectedField
    {
        protected readonly int ProtectedField;

        public BaseClass_With_ProtectedField(int value) => ProtectedField = value;

        public int Get_ProtectedField() => ProtectedField;
    }
}