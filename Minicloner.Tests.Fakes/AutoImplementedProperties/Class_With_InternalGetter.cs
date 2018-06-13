namespace Minicloner.Tests.Fakes.AutoImplementedProperties
{
    public class Class_With_InternalGetter
    {
        public int Property_With_InternalGetter { internal get; set; }

        public int Get_Property_With_InternalGetter() => Property_With_InternalGetter;
    }
}