namespace Minicloner.Tests.OtherAssembly.Fakes.Static
{
    public class Class_With_ProtectedInternalStaticReferenceTypeField_From_OtherAssembly
    {
        protected internal static EmptyClass_From_OtherAssembly ProtectedInternalStaticReferenceTypeField;

        public Class_With_ProtectedInternalStaticReferenceTypeField_From_OtherAssembly(EmptyClass_From_OtherAssembly referenceTypeParameter)
        {
            ProtectedInternalStaticReferenceTypeField = referenceTypeParameter;
        }

        public static EmptyClass_From_OtherAssembly Get_ProtectedInternalStaticReferenceTypeField()
        {
            return ProtectedInternalStaticReferenceTypeField;
        }
    }
}