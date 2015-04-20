namespace Minicloner.Tests.Fakes.Static
{
    public class Class_With_PrivateStaticReferenceTypeField
    {
        private static EmptyClass _privateStaticReferenceTypeField;

        public Class_With_PrivateStaticReferenceTypeField(EmptyClass referenceTypeParameter)
        {
            _privateStaticReferenceTypeField = referenceTypeParameter;
        }

        public static EmptyClass Get_PrivateStaticReferenceTypeProperty()
        {
            return _privateStaticReferenceTypeField;
        }
    }
}