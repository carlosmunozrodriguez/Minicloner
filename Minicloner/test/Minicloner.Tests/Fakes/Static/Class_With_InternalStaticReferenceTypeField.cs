namespace Minicloner.Tests.Fakes.Static
{
    public class Class_With_ProtectedInternalStaticReferenceTypeField
    {
        protected internal static EmptyClass ProtectedInternalStaticReferenceTypeField;

        public Class_With_ProtectedInternalStaticReferenceTypeField(EmptyClass referenceTypeParameter)
        {
            ProtectedInternalStaticReferenceTypeField = referenceTypeParameter;
        }
    }
}