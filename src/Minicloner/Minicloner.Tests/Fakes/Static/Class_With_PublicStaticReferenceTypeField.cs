namespace Minicloner.Tests.Fakes.Static
{
    public class Class_With_PublicStaticReferenceTypeField
    {
        public static EmptyClass PublicStaticReferenceTypeField;

        public Class_With_PublicStaticReferenceTypeField(EmptyClass referenceTypeParameter)
        {
            PublicStaticReferenceTypeField = referenceTypeParameter;
        }
    }
}