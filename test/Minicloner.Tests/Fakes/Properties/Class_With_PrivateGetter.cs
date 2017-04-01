namespace Minicloner.Tests.Fakes.Properties
{
    public class Class_With_PrivateGetter
    {
        public int Int32Property_With_PrivateGetter { private get; set; }

        public int Get_Int32Property_With_PrivateGetter() => Int32Property_With_PrivateGetter;
    }
}