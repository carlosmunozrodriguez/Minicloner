namespace Minicloner.Tests.Fakes.AutoImplementedProperties
{
    public class Class_With_ProtectedInternalSetter
    {
        public int Property_With_ProtectedInternalSetter { get; protected internal set; }

        public void Set_Property_With_ProtectedInternalSetter(int value) => Property_With_ProtectedInternalSetter = value;
    }
}