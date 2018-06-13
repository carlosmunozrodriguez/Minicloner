namespace Minicloner.Tests.Fakes.Inheritance
{
    public class DerivedClass_With_PrivateField : EmptyBaseClass
    {
        private readonly int _privateField;

        public DerivedClass_With_PrivateField(int value) => _privateField = value;

        public int Get_PrivateField() => _privateField;
    }
}