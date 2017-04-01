namespace Minicloner.Tests.Fakes.Fields
{
    public class Class_With_PrivateField
    {
        private readonly int _privateField;

        public Class_With_PrivateField(int parameter)
        {
            _privateField = parameter;
        }

        public int Get_PrivateField() => _privateField;
    }
}