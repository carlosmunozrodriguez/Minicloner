using Minicloner.Tests.Fakes.Fields;
using Xunit;

namespace Minicloner.Tests
{
    public class CloneAnonymousTypesTests
    {
        [Fact]
        public void Clone_AnonymousClass_With_PrimitiveValueTypeProperty()
        {
            var anonymousTypedObject = new { Int32 = 1 };
            var cloned = new Cloner().Clone(anonymousTypedObject);

            Assert.NotSame(anonymousTypedObject, cloned);
            Assert.Equal(anonymousTypedObject.Int32, cloned.Int32);
        }

        [Fact]
        public void Clone_AnonymousClass_With_ReferenceTypeProperty()
        {
            var anonymousTypedObject = new { Object = new Class_With_PublicField { PublicField = 1 } };
            var cloned = new Cloner().Clone(anonymousTypedObject);

            Assert.NotSame(anonymousTypedObject, cloned);
            Assert.NotSame(anonymousTypedObject.Object, cloned.Object);
            Assert.Equal(anonymousTypedObject.Object.PublicField, cloned.Object.PublicField);
        }
    }
}