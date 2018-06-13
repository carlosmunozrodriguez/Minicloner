namespace Minicloner.Tests.Fakes.AutoImplementedProperties
{
    public class Class_With_PrivateProtectedSetter
    {
        public int Property_With_PrivateProtectedSetter { get; private protected set; }

        public void Set_Property_With_PrivateProtectedSetter(int value) => Property_With_PrivateProtectedSetter = value;
    }
}