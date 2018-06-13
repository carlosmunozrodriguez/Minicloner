namespace Minicloner.Tests.Fakes.AutoImplementedProperties
{
    public class Class_With_ProtectedGetter
    {
        public int Property_With_ProtectedGetter { protected get; set; }

        public int Get_Property_With_ProtectedGetter() => Property_With_ProtectedGetter;
    }
}