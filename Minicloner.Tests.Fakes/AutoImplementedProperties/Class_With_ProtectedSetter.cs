namespace Minicloner.Tests.Fakes.AutoImplementedProperties
{
    public class Class_With_ProtectedSetter
    {
        public int Property_With_ProtectedSetter { get; protected set; }

        public void Set_Property_With_ProtectedSetter(int value) => Property_With_ProtectedSetter = value;
    }
}