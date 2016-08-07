namespace Minicloner.Tests.Fakes.CircularReference
{
    public class ReflexiveClass
    {
        public int Int32Property { get; private set; }

        public ReflexiveClass Self { get; set; }

        public ReflexiveClass(int int32Parameter)
        {
            Int32Property = int32Parameter;
            Self = this;
        }
    }
}