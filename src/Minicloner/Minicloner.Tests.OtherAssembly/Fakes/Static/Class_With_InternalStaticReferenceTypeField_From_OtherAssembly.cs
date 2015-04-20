namespace Minicloner.Tests.OtherAssembly.Fakes.Static
{
    public class Class_With_InternalStaticReferenceTypeField_From_OtherAssembly
    {
        internal static EmptyClass_From_OtherAssembly InternalStaticReferenceTypeField;

        public Class_With_InternalStaticReferenceTypeField_From_OtherAssembly(EmptyClass_From_OtherAssembly referenceTypeParameter)
        {
            InternalStaticReferenceTypeField = referenceTypeParameter;
        }

        public static EmptyClass_From_OtherAssembly Get_InternalStaticReferenceTypeField()
        {
            return InternalStaticReferenceTypeField;
        }
    }
}