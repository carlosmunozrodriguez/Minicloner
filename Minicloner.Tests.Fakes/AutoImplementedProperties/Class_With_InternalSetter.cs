namespace Minicloner.Tests.Fakes.AutoImplementedProperties
{
    public class Class_With_InternalSetter
    {
        public int Property_With_InternalSetter { get; internal set; }

        public void Set_Property_With_InternalSetter(int value) => Property_With_InternalSetter = value;
    }
}