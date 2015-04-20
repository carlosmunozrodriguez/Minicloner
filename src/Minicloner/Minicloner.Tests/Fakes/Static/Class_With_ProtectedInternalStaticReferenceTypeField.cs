namespace Minicloner.Tests.Fakes.Static
{
    public class Class_With_InternalStaticReferenceTypeField
    {
        internal static EmptyClass InternalStaticReferenceTypeField;

        public Class_With_InternalStaticReferenceTypeField(EmptyClass referenceTypeParameter)
        {
            InternalStaticReferenceTypeField = referenceTypeParameter;
        }
    }
}