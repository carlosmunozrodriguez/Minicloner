namespace Minicloner.Tests.Fakes.CircularReference
{
    public class MutuallyDependentClassA
    {
        public int Property { get; }

        public MutuallyDependentClassB B { get; set; }

        public MutuallyDependentClassA(int value) => Property = value;
    }
}