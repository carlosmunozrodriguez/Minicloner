using Minicloner.Tests.Fakes.Constructors;
using Minicloner.Tests.OtherAssembly.Fakes;
using Minicloner.Tests.OtherAssembly.Fakes.Constructors;
using Xunit;

namespace Minicloner.Tests.Classes
{
    public class CloneClassesConstructorsTests
    {
        [Fact]
        public void Clone_Class_With_DefaultConstructor()
        {
            var source = new Class_With_DefaultConstructor { Int32Property = 1 };
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_DefaultConstructor>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.Int32Property, cloned.Int32Property);
        }

        #region Parameterless constructors
        [Fact]
        public void Clone_Class_With_PublicParameterlessConstructor()
        {
            var source = new Class_With_PublicParameterlessConstructor { Int32Property = 2 };
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_PublicParameterlessConstructor>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.PropertyInitializedInConstructor, cloned.PropertyInitializedInConstructor);
            Assert.Equal(source.Int32Property, cloned.Int32Property);
        }

        [Fact]
        public void Clone_Class_With_PrivateParameterlessConstructor()
        {
            var source = Class_With_PrivateParameterlessConstructor.Create();
            source.Int32Property = 2;

            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_PrivateParameterlessConstructor>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.PropertyInitializedInConstructor, cloned.PropertyInitializedInConstructor);
            Assert.Equal(source.Int32Property, cloned.Int32Property);
        }

        [Fact]
        public void Clone_Class_With_ProtectedParameterlessConstructor()
        {
            var source = Class_With_ProtectedParameterlessConstructor.Create();
            source.Int32Property = 2;

            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_ProtectedParameterlessConstructor>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.PropertyInitializedInConstructor, cloned.PropertyInitializedInConstructor);
            Assert.Equal(source.Int32Property, cloned.Int32Property);
        }

        [Fact]
        public void Clone_Class_With_InternalParameterlessConstructor()
        {
            var source = new Class_With_InternalParameterlessConstructor { Int32Property = 2 };
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_InternalParameterlessConstructor>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.PropertyInitializedInConstructor, cloned.PropertyInitializedInConstructor);
            Assert.Equal(source.Int32Property, cloned.Int32Property);
        }

        [Fact]
        public void Clone_Class_With_InternalParameterlessConstructor_From_OtherAssembly()
        {
            var source = Class_With_InternalParameterlessConstructor_From_OtherAssembly.Create();
            source.Int32Property = 2;
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_InternalParameterlessConstructor_From_OtherAssembly>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.PropertyInitializedInConstructor, cloned.PropertyInitializedInConstructor);
            Assert.Equal(source.Int32Property, cloned.Int32Property);
        }

        [Fact]
        public void Clone_Class_With_ProtectedInternalParameterlessConstructor()
        {
            var source = new Class_With_ProtectedInternalParameterlessConstructor { Int32Property = 2 };
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_ProtectedInternalParameterlessConstructor>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.PropertyInitializedInConstructor, cloned.PropertyInitializedInConstructor);
            Assert.Equal(source.Int32Property, cloned.Int32Property);
        }

        [Fact]
        public void Clone_Class_With_ProtectedInternalParameterlessConstructor_From_OtherAssembly()
        {
            var source = Class_With_ProtectedInternalParameterlessConstructor_From_OtherAssembly.Create();
            source.Int32Property = 2;
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_ProtectedInternalParameterlessConstructor_From_OtherAssembly>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.PropertyInitializedInConstructor, cloned.PropertyInitializedInConstructor);
            Assert.Equal(source.Int32Property, cloned.Int32Property);
        }
        #endregion

        [Fact]
        public void Clone_Class_Without_OneParameterConstructor()
        {
            var source = new Class_With_OneParameterConstructor(1);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_OneParameterConstructor>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.Int32Property, cloned.Int32Property);
        }

        [Fact]
        public void Clone_Class_With_OneParameterConstructor_And_ParameterlessContructor()
        {
            var source = new Class_With_OneParameterConstructor_And_ParameterlessContructor(1);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_OneParameterConstructor_And_ParameterlessContructor>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.Int32Property, cloned.Int32Property);
        }

        [Fact]
        public void Clone_Class_With_Two_NonParameterlessConstructors()
        {
            var source = new Class_With_Two_NonParameterlessConstructors(2, 3);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_Two_NonParameterlessConstructors>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.Int32Property, cloned.Int32Property);
        }
    }
}