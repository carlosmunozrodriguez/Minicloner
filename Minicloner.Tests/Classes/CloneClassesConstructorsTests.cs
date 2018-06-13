using Minicloner.Tests.Fakes.Constructors;
using Xunit;

namespace Minicloner.Tests.Classes
{
    public class CloneClassesConstructorsTests
    {
        [Fact]
        public void Clone_Class_With_DefaultConstructor()
        {
            var source = new Class_With_DefaultConstructor { Property = 1 };
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_DefaultConstructor>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.Property, cloned.Property);
        }

        #region Parameterless constructors
        [Fact]
        public void Clone_Class_With_PublicParameterlessConstructor()
        {
            var source = new Class_With_PublicParameterlessConstructor { Property = 2 };
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_PublicParameterlessConstructor>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.PropertyInitializedInConstructor, cloned.PropertyInitializedInConstructor);
            Assert.Equal(source.Property, cloned.Property);
        }

        [Fact]
        public void Clone_Class_With_PrivateParameterlessConstructor()
        {
            var source = Class_With_PrivateParameterlessConstructor.Create();
            source.Property = 2;

            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_PrivateParameterlessConstructor>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.PropertyInitializedInConstructor, cloned.PropertyInitializedInConstructor);
            Assert.Equal(source.Property, cloned.Property);
        }

        [Fact]
        public void Clone_Class_With_ProtectedParameterlessConstructor()
        {
            var source = Class_With_ProtectedParameterlessConstructor.Create();
            source.Property = 2;

            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_ProtectedParameterlessConstructor>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.PropertyInitializedInConstructor, cloned.PropertyInitializedInConstructor);
            Assert.Equal(source.Property, cloned.Property);
        }

        [Fact]
        public void Clone_Class_With_InternalParameterlessConstructor()
        {
            var source = Class_With_InternalParameterlessConstructor.Create();
            source.Property = 2;
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_InternalParameterlessConstructor>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.PropertyInitializedInConstructor, cloned.PropertyInitializedInConstructor);
            Assert.Equal(source.Property, cloned.Property);
        }

        [Fact]
        public void Clone_Class_With_ProtectedInternalParameterlessConstructor()
        {
            var source = Class_With_ProtectedInternalParameterlessConstructor.Create();
            source.Property = 2;
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_ProtectedInternalParameterlessConstructor>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.PropertyInitializedInConstructor, cloned.PropertyInitializedInConstructor);
            Assert.Equal(source.Property, cloned.Property);
        }

        [Fact]
        public void Clone_Class_With_PrivateProtectedParameterlessConstructor()
        {
            var source = Class_With_PrivateProtectedParameterlessConstructor.Create();
            source.Property = 2;
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_PrivateProtectedParameterlessConstructor>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.PropertyInitializedInConstructor, cloned.PropertyInitializedInConstructor);
            Assert.Equal(source.Property, cloned.Property);
        }
        #endregion

        [Fact]
        public void Clone_Class_With_OneParameterConstructor()
        {
            var source = new Class_With_OneParameterConstructor(1);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_OneParameterConstructor>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.Property, cloned.Property);
        }

        [Fact]
        public void Clone_Class_With_OneParameterConstructor_And_ParameterlessContructor_Using_OneParameterConstructor()
        {
            var source = new Class_With_OneParameterConstructor_And_ParameterlessContructor(1);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_OneParameterConstructor_And_ParameterlessContructor>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.Property, cloned.Property);
        }

        [Fact]
        public void Clone_Class_With_OneParameterConstructor_And_ParameterlessContructor_Using_ParameterlessContructor()
        {
            var source = new Class_With_OneParameterConstructor_And_ParameterlessContructor();
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_OneParameterConstructor_And_ParameterlessContructor>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.Property, cloned.Property);
        }

        [Fact]
        public void Clone_Class_With_Two_NonParameterlessConstructors_Using_FirstConstructor()
        {
            var source = new Class_With_Two_NonParameterlessConstructors(2);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_Two_NonParameterlessConstructors>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.Property, cloned.Property);
        }

        [Fact]
        public void Clone_Class_With_Two_NonParameterlessConstructors_Using_SecondConstructor()
        {
            var source = new Class_With_Two_NonParameterlessConstructors(2, 3);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_Two_NonParameterlessConstructors>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.Property, cloned.Property);
        }
    }
}