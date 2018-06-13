using Minicloner.Tests.Fakes.AutoImplementedProperties;
using Xunit;

namespace Minicloner.Tests.Classes
{
    public class CloneClassesAutoImplementedProperties
    {

        [Fact]
        public void Clone_Class_With_PublicAutoImplementedProperty()
        {
            var source = new Class_With_PublicAutoImplementedProperty { PublicAutoImplementedProperty = 1 };
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_PublicAutoImplementedProperty>(cloned);
            Assert.NotSame(source, cloned);
            Assert.Equal(source.PublicAutoImplementedProperty, cloned.PublicAutoImplementedProperty);
        }

        #region Setters
        [Fact]
        public void Clone_Class_With_PrivateSetter()
        {
            var source = new Class_With_PrivateSetter();
            source.Set_Property_With_PrivateSetter(1);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_PrivateSetter>(cloned);
            Assert.NotSame(source, cloned);
            Assert.Equal(source.Property_With_PrivateSetter, cloned.Property_With_PrivateSetter);
        }

        [Fact]
        public void Clone_Class_With_ProtectedSetter()
        {
            var source = new Class_With_ProtectedSetter();
            source.Set_Property_With_ProtectedSetter(1);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_ProtectedSetter>(cloned);
            Assert.NotSame(source, cloned);
            Assert.Equal(source.Property_With_ProtectedSetter, cloned.Property_With_ProtectedSetter);
        }

        [Fact]
        public void Clone_Class_With_InternalSetter()
        {
            var source = new Class_With_InternalSetter();
            source.Set_Property_With_InternalSetter(1);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_InternalSetter>(cloned);
            Assert.NotSame(source, cloned);
            Assert.Equal(source.Property_With_InternalSetter, cloned.Property_With_InternalSetter);
        }

        [Fact]
        public void Clone_Class_With_ProtectedInternalSetter()
        {
            var source = new Class_With_ProtectedInternalSetter();
            source.Set_Property_With_ProtectedInternalSetter(1);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_ProtectedInternalSetter>(cloned);
            Assert.NotSame(source, cloned);
            Assert.Equal(source.Property_With_ProtectedInternalSetter, cloned.Property_With_ProtectedInternalSetter);
        }

        [Fact]
        public void Clone_Class_With_PrivateProtectedSetter()
        {
            var source = new Class_With_PrivateProtectedSetter();
            source.Set_Property_With_PrivateProtectedSetter(1);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_PrivateProtectedSetter>(cloned);
            Assert.NotSame(source, cloned);
            Assert.Equal(source.Property_With_PrivateProtectedSetter, cloned.Property_With_PrivateProtectedSetter);
        }
        #endregion

        #region Getters
        [Fact]
        public void Clone_Class_With_PrivateGetter()
        {
            var source = new Class_With_PrivateGetter { Property_With_PrivateGetter = 1 };
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_PrivateGetter>(cloned);
            Assert.NotSame(source, cloned);
            Assert.Equal(source.Get_Property_With_PrivateGetter(), cloned.Get_Property_With_PrivateGetter());
        }

        [Fact]
        public void Clone_Class_With_ProtectedGetter()
        {
            var source = new Class_With_ProtectedGetter { Property_With_ProtectedGetter = 1 };
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_ProtectedGetter>(cloned);
            Assert.NotSame(source, cloned);
            Assert.Equal(source.Get_Property_With_ProtectedGetter(), cloned.Get_Property_With_ProtectedGetter());
        }

        [Fact]
        public void Clone_Class_With_InternalGetter()
        {
            var source = new Class_With_InternalGetter { Property_With_InternalGetter = 1 };
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_InternalGetter>(cloned);
            Assert.NotSame(source, cloned);
            Assert.Equal(source.Get_Property_With_InternalGetter(), cloned.Get_Property_With_InternalGetter());
        }

        [Fact]
        public void Clone_Class_With_ProtectedInternalGetter()
        {
            var source = new Class_With_ProtectedInternalGetter { Property_With_ProtectedInternalGetter = 1 };
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_ProtectedInternalGetter>(cloned);
            Assert.NotSame(source, cloned);
            Assert.Equal(source.Get_Property_With_ProtectedInternalGetter(), cloned.Get_Property_With_ProtectedInternalGetter());
        }

        [Fact]
        public void Clone_Class_With_PrivateProtectedGetter()
        {
            var source = new Class_With_PrivateProtectedGetter { Property_With_PrivateProtectedGetter = 1 };
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_PrivateProtectedGetter>(cloned);
            Assert.NotSame(source, cloned);
            Assert.Equal(source.Get_Property_With_PrivateProtectedGetter(), cloned.Get_Property_With_PrivateProtectedGetter());
        }
        #endregion
    }
}