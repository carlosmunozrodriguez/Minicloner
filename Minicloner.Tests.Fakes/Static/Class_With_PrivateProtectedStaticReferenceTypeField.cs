namespace Minicloner.Tests.Fakes.Static
{
    public class Class_With_PrivateProtectedStaticReferenceTypeField
    {
        private protected static EmptyClass PrivateProtectedStaticReferenceTypeField;

        public Class_With_PrivateProtectedStaticReferenceTypeField(EmptyClass referenceTypeParameter) => PrivateProtectedStaticReferenceTypeField = referenceTypeParameter;

        public static EmptyClass Get_PrivateProtectedStaticReferenceTypeField() => PrivateProtectedStaticReferenceTypeField;
    }
}