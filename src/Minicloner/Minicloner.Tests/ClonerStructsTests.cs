using System;
using Xunit;

namespace Minicloner.Tests
{
    public class ClonerStructsTests
    {
        [Fact]
        public void CloneEmptyStruct()
        {
            var emptyStruct = new EmptyStruct();
            var cloned = new Cloner().Clone(emptyStruct);

            Assert.IsType<EmptyStruct>(cloned);
            Assert.NotSame(emptyStruct, cloned);
        }

        [Fact]
        public void CloneStructWithPublicField()
        {
            var structWithPublicField = new StructWithPublicValueTypeField { PublicInt32Field = 1 };
            var cloned = new Cloner().Clone(structWithPublicField);

            Assert.IsType<StructWithPublicValueTypeField>(cloned);
            Assert.NotSame(structWithPublicField, cloned);
            Assert.Equal(structWithPublicField.PublicInt32Field, cloned.PublicInt32Field);
        }
    }

    public struct EmptyStruct
    {
    }

    public struct StructWithPublicValueTypeField
    {
        public Int32 PublicInt32Field;
    }
}
