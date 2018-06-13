namespace Minicloner.Tests.Fakes.AutoImplementedProperties
{
    public class Class_With_ProtectedInternalGetter
    {
        public int Property_With_ProtectedInternalGetter { protected internal get; set; }

        public int Get_Property_With_ProtectedInternalGetter() => Property_With_ProtectedInternalGetter;
    }
}