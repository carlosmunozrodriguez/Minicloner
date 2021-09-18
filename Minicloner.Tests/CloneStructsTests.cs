using Minicloner.Tests.Fakes.Fields;
using Minicloner.Tests.Fakes.Structs;
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
            Assert.Equal(emptyStruct, cloned);
        }

        [Fact]
        public void Clone_Struct_With_ValueTypeField()
        {
            var structWithPublicValueTypeField = new StructWithPublicValueTypeField { PublicField = 1 };
            var cloned = new Cloner().Clone(structWithPublicValueTypeField);

            Assert.IsType<StructWithPublicValueTypeField>(cloned);
            Assert.Equal(structWithPublicValueTypeField, cloned);
            Assert.Equal(structWithPublicValueTypeField.PublicField, cloned.PublicField);
        }

        [Fact]
        public void Clone_Struct_With_ReferenceTypeField()
        {
            var structWithPublicField = new StructWithPublicReferenceTypeField
            {
                ClassWithPublicField = new Class_With_PublicField
                {
                    PublicField = 1
                }
            };
            var cloned = new Cloner().Clone(structWithPublicField);

            Assert.IsType<StructWithPublicReferenceTypeField>(cloned);
            Assert.NotSame(structWithPublicField.ClassWithPublicField, cloned.ClassWithPublicField);
            Assert.Equal(structWithPublicField.ClassWithPublicField.PublicField, cloned.ClassWithPublicField.PublicField);
        }
    }
}