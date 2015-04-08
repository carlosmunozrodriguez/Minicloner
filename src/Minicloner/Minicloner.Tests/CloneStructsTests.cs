using Minicloner.Tests.Fakes;
using Xunit;

namespace Minicloner.Tests
{
    public class CloneStructsTests
    {
        [Fact]
        public void Clone_EmptyStruct()
        {
            var emptyStruct = new EmptyStruct();
            var cloned = new Cloner().Clone(emptyStruct);

            Assert.IsType<EmptyStruct>(cloned);
            Assert.NotSame(emptyStruct, cloned);
        }

        [Fact]
        public void Clone_Struct_With_PublicField()
        {
            var structWithPublicField = new Struct_With_PublicValueTypeField { PublicInt32Field = 1 };
            var cloned = new Cloner().Clone(structWithPublicField);

            Assert.IsType<Struct_With_PublicValueTypeField>(cloned);
            Assert.NotSame(structWithPublicField, cloned);
            Assert.Equal(structWithPublicField.PublicInt32Field, cloned.PublicInt32Field);
        }
    }
}