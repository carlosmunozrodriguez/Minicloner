namespace Minicloner.Tests.Fakes.AutoImplementedProperties
{
    public class Class_With_PrivateGetter
    {
        public int Property_With_PrivateGetter { private get; set; }

        public int Get_Property_With_PrivateGetter() => Property_With_PrivateGetter;
    }
}