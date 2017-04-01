namespace Minicloner.Tests.Fakes.Constructors
{
    public class Class_With_ProtectedParameterlessConstructor
    {
        public int Int32Property { get; set; }
        public int PropertyInitializedInConstructor { get; private set; }

        protected Class_With_ProtectedParameterlessConstructor()
        {
            PropertyInitializedInConstructor = 1;
        }

        public static Class_With_ProtectedParameterlessConstructor Create() => new Class_With_ProtectedParameterlessConstructor();
    }
}