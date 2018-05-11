namespace Minicloner.Tests.Fakes.Properties
{
    public class Class_With_PrivateSetter
    {
        public int Int32Property_With_PrivateSetter { get; private set; }

        public void Set_Int32Property_With_PrivateSetter(int int32Parameter) => Int32Property_With_PrivateSetter = int32Parameter;
    }
}