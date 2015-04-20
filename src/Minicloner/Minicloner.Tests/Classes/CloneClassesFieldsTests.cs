using Minicloner.Test.OtherAssembly.Fakes;
using Minicloner.Tests.Fakes.Fields;
using Xunit;

namespace Minicloner.Tests.Classes
{
    public class CloneClassesFieldsTests
    {
        [Fact]
        public void Clone_Class_With_PublicField()
        {
            var source = new Class_With_PublicField { PublicField = 1 };
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_PublicField>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.PublicField, cloned.PublicField);
        }

        [Fact]
        public void Clone_Class_With_PrivateField()
        {
            var source = new Class_With_PrivateField(1);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_PrivateField>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.Get_PrivateField(), cloned.Get_PrivateField());
        }

        [Fact]
        public void Clone_Class_With_ProtectedField()
        {
            var source = new Class_With_ProtectedField(1);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_ProtectedField>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.Get_ProtectedField(), cloned.Get_ProtectedField());
        }

        [Fact]
        public void Clone_Class_With_InternalField()
        {
            var source = new Class_With_InternalField { InternalField = 1 };
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_InternalField>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.InternalField, cloned.InternalField);
        }

        [Fact]
        public void Clone_Class_With_InternalField_From_OtherAssembly()
        {
            var source = new Class_With_InternalField_From_OtherAssembly(1);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_InternalField_From_OtherAssembly>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.Get_InternalField(), cloned.Get_InternalField());
        }

        [Fact]
        public void Clone_Class_With_ProtectedInternalField()
        {
            var source = new Class_With_ProtectedInternalField { ProtectedInternalField = 1 };
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_ProtectedInternalField>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.ProtectedInternalField, cloned.ProtectedInternalField);
        }

        [Fact]
        public void Clone_Class_With_ProtectedInternalField_From_OtherAssembly()
        {
            var source = new Class_With_ProtectedInternalField_From_OtherAssembly(1);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_ProtectedInternalField_From_OtherAssembly>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.Get_ProtectedInternalField(), cloned.Get_ProtectedInternalField());
        }
    }
}