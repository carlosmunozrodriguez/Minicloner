namespace Minicloner.Tests.Fakes.CircularReference
{
    public class ReflexiveClass
    {
        public int Property { get; }

        public ReflexiveClass Self { get; }

        public ReflexiveClass(int value)
        {
            Property = value;
            Self = this;
        }
    }
}