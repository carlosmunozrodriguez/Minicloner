namespace Minicloner.Tests.Fakes.Static
{
    public class Class_With_ProtectedStaticReferenceTypeField
    {
        protected static EmptyClass ProtectedStaticReferenceTypeField;

        public Class_With_ProtectedStaticReferenceTypeField(EmptyClass referenceTypeParameter) => ProtectedStaticReferenceTypeField = referenceTypeParameter;

        public static EmptyClass Get_ProtectedStaticReferenceTypeProperty() => ProtectedStaticReferenceTypeField;
    }
}