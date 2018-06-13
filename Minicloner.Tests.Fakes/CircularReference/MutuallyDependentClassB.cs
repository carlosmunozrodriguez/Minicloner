namespace Minicloner.Tests.Fakes.CircularReference
{
    public class MutuallyDependentClassB
    {
        public int Property { get; }

        public MutuallyDependentClassA A { get; set; }

        public MutuallyDependentClassB(int value) => Property = value;
    }
}