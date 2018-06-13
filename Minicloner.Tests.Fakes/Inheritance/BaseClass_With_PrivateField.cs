namespace Minicloner.Tests.Fakes.Inheritance
{
    public class BaseClass_With_PrivateField
    {
        private readonly int _privateField;

        public BaseClass_With_PrivateField(int value) => _privateField = value;

        public int Get_PrivateField() => _privateField;
    }
}