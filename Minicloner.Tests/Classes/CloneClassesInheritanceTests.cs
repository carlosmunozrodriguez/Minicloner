using Minicloner.Tests.Fakes.Inheritance;
using Xunit;

namespace Minicloner.Tests.Classes
{
    public class CloneClassesInheritanceTests
    {
        #region Field in derived class
        [Fact]
        public void Clone_DerivedClass_With_PublicField()
        {
            var source = new DerivedClass_With_PublicField { PublicField = 1 };
            var cloned = new Cloner().Clone(source);

            Assert.IsType<DerivedClass_With_PublicField>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.PublicField, cloned.PublicField);
        }

        [Fact]
        public void Clone_DerivedClass_With_PrivateField()
        {
            var source = new DerivedClass_With_PrivateField(1);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<DerivedClass_With_PrivateField>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.Get_PrivateField(), cloned.Get_PrivateField());
        }

        [Fact]
        public void Clone_DerivedClass_With_ProtectedField()
        {
            var source = new DerivedClass_With_ProtectedField(1);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<DerivedClass_With_ProtectedField>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.Get_ProtectedField(), cloned.Get_ProtectedField());
        }

        [Fact]
        public void Clone_DerivedClass_With_InternalField()
        {
            var source = new DerivedClass_With_InternalField(1);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<DerivedClass_With_InternalField>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.Get_InternalField(), cloned.Get_InternalField());
        }

        [Fact]
        public void Clone_DerivedClass_With_ProtectedInternalField()
        {
            var source = new DerivedClass_With_ProtectedInternalField(1);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<DerivedClass_With_ProtectedInternalField>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.Get_ProtectedInternalField(), cloned.Get_ProtectedInternalField());
        }

        [Fact]
        public void Clone_DerivedClass_With_PrivateProtectedField()
        {
            var source = new DerivedClass_With_PrivateProtectedField(1);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<DerivedClass_With_PrivateProtectedField>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.Get_PrivateProtectedField(), cloned.Get_PrivateProtectedField());
        }
        #endregion

        #region Field in base class
        [Fact]
        public void Clone_Derived_From_BaseClass_With_PublicField()
        {
            var source = new Derived_From_BaseClass_With_PublicField { PublicField = 1 };
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Derived_From_BaseClass_With_PublicField>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.PublicField, cloned.PublicField);
        }

        [Fact]
        public void Clone_Derived_From_BaseClass_With_PrivateField()
        {
            var source = new Derived_From_BaseClass_With_PrivateField(1);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Derived_From_BaseClass_With_PrivateField>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.Get_PrivateField(), cloned.Get_PrivateField());
        }

        [Fact]
        public void Clone_Derived_From_BaseClass_With_ProtectedField()
        {
            var source = new Derived_From_BaseClass_With_ProtectedField(1);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Derived_From_BaseClass_With_ProtectedField>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.Get_ProtectedField(), cloned.Get_ProtectedField());
        }

        [Fact]
        public void Clone_Derived_From_BaseClass_With_InternalField()
        {
            var source = new Derived_From_BaseClass_With_InternalField(1);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Derived_From_BaseClass_With_InternalField>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.Get_InternalField(), cloned.Get_InternalField());
        }

        [Fact]
        public void Clone_Derived_From_BaseClass_With_ProtectedInternalField()
        {
            var source = new Derived_From_BaseClass_With_ProtectedInternalField(1);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Derived_From_BaseClass_With_ProtectedInternalField>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.Get_ProtectedInternalField(), cloned.Get_ProtectedInternalField());
        }

        [Fact]
        public void Clone_Derived_From_BaseClass_With_PrivateProtectedField()
        {
            var source = new Derived_From_BaseClass_With_PrivateProtectedField(1);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Derived_From_BaseClass_With_PrivateProtectedField>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.Get_PrivateProtectedField(), cloned.Get_PrivateProtectedField());
        }
        #endregion
    }
}