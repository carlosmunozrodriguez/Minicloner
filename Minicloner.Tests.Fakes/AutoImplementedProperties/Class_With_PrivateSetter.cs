namespace Minicloner.Tests.Fakes.AutoImplementedProperties
{
    public class Class_With_PrivateSetter
    {
        public int Property_With_PrivateSetter { get; private set; }

        public void Set_Property_With_PrivateSetter(int value) => Property_With_PrivateSetter = value;
    }
}