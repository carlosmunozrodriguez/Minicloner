namespace Minicloner.Tests.Fakes.CircularReference
{
    public class MutuallyDependentClassB
    {
        public int Int32Property { get; private set; }

        public MutuallyDependentClassA A { get; set; }

        public MutuallyDependentClassB(int int32Parameter) => Int32Property = int32Parameter;
    }
}