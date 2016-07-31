namespace Minicloner.Tests.Fakes.CircularReference
{
    public class MutuallyDependentClassA
    {
        public int Int32Property { get; private set; }

        public MutuallyDependentClassB B { get; set; }

        public MutuallyDependentClassA(int int32Parameter)
        {
            Int32Property = int32Parameter;
        }
    }
}