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
#pragma warning disable xUnit2005 // We are comparing instances not values
            Assert.NotSame(emptyStruct, cloned);
#pragma warning restore xUnit2005
        }

        [Fact]
        public void Clone_Struct_With_PublicField()
        {
            var structWithPublicField = new Struct_With_PublicValueTypeField { PublicInt32Field = 1 };
            var cloned = new Cloner().Clone(structWithPublicField);

            Assert.IsType<Struct_With_PublicValueTypeField>(cloned);
#pragma warning disable xUnit2005 // We are comparing instances not values
            Assert.NotSame(structWithPublicField, cloned);
#pragma warning restore xUnit2005
            Assert.Equal(structWithPublicField.PublicInt32Field, cloned.PublicInt32Field);
        }
    }
}