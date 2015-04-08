namespace Minicloner.Tests.Fakes
{
    public class ClassWithTwoLevelsOfReferenceTypeProperties
    {
        public ClassWithPublicAutomaticallyImplementedProperty ReferenceTypeProperty { get; set; }
        public ClassWithReferenceTypeProperty TwoLeveledReferenceTypeProperty { get; set; }
    }
}