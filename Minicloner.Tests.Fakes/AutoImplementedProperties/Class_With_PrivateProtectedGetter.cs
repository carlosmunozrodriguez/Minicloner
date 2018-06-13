namespace Minicloner.Tests.Fakes.AutoImplementedProperties
{
    public class Class_With_PrivateProtectedGetter
    {
        public int Property_With_PrivateProtectedGetter { private protected get; set; }

        public int Get_Property_With_PrivateProtectedGetter() => Property_With_PrivateProtectedGetter;
    }
}