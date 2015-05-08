using Minicloner.Tests.Fakes.Inheritance;
using Minicloner.Tests.OtherAssembly.Fakes.Inheritance;
using Xunit;

namespace Minicloner.Tests.Classes
{
    public class CloneClassesInheritanceTests
    {
        [Fact]
        public void Clone_DerivedClass_With_PublicField()
        {
            var source = new DerivedClass_With_PublicField { PublicField_In_BaseClass = 1, PublicField_In_DerivedClass = 2 };
            var cloned = new Cloner().Clone(source);

            Assert.IsType<DerivedClass_With_PublicField>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.PublicField_In_DerivedClass, cloned.PublicField_In_DerivedClass);
            Assert.Equal(source.PublicField_In_BaseClass, cloned.PublicField_In_BaseClass);
        }

        [Fact]
        public void Clone_DerivedClass_With_PrivateField()
        {
            var source = new DerivedClass_With_PrivateField();
            source.Set_PrivateField_In_BaseClass(1);
            source.Set_PrivateField_In_DerivedClass(2);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<DerivedClass_With_PrivateField>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.Get_PrivateField_In_DerivedClass(), cloned.Get_PrivateField_In_DerivedClass());
            Assert.Equal(source.Get_PrivateField_In_BaseClass(), cloned.Get_PrivateField_In_BaseClass());
        }

        [Fact]
        public void Clone_DerivedClass_With_ProtectedField()
        {
            var source = new DerivedClass_With_ProtectedField();
            source.Set_ProtectedField_In_BaseClass(1);
            source.Set_ProtectedField_In_DerivedClass(2);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<DerivedClass_With_ProtectedField>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.Get_ProtectedField_In_DerivedClass(), cloned.Get_ProtectedField_In_DerivedClass());
            Assert.Equal(source.Get_ProtectedField_In_BaseClass(), cloned.Get_ProtectedField_In_BaseClass());
        }

        [Fact]
        public void Clone_DerivedClass_With_InternalField()
        {
            var source = new DerivedClass_With_InternalField { InternalField_In_BaseClass = 1, InternalField_In_DerivedClass = 2 };
            var cloned = new Cloner().Clone(source);

            Assert.IsType<DerivedClass_With_InternalField>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.InternalField_In_DerivedClass, cloned.InternalField_In_DerivedClass);
            Assert.Equal(source.InternalField_In_BaseClass, cloned.InternalField_In_BaseClass);
        }

        [Fact]
        public void Clone_DerivedClass_With_InternalField_From_OtherAssembly()
        {
            var source = new DerivedClass_With_InternalField_From_OtherAssembly();
            source.Set_InternalField_In_BaseClass(1);
            source.Set_InternalField_In_DerivedClass(2);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<DerivedClass_With_InternalField_From_OtherAssembly>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.Get_InternalField_In_DerivedClass(), cloned.Get_InternalField_In_DerivedClass());
            Assert.Equal(source.Get_InternalField_In_BaseClass(), cloned.Get_InternalField_In_BaseClass());
        }

        [Fact]
        public void Clone_DerivedClass_With_ProtectedInternalField()
        {
            var source = new DerivedClass_With_ProtectedInternalField { ProtectedInternalField_In_BaseClass = 1, ProtectedInternalField_In_DerivedClass = 2 };
            var cloned = new Cloner().Clone(source);

            Assert.IsType<DerivedClass_With_ProtectedInternalField>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.ProtectedInternalField_In_DerivedClass, cloned.ProtectedInternalField_In_DerivedClass);
            Assert.Equal(source.ProtectedInternalField_In_BaseClass, cloned.ProtectedInternalField_In_BaseClass);
        }

        [Fact]
        public void Clone_DerivedClass_With_ProtectedInternalField_From_OtherAssembly()
        {
            var source = new DerivedClass_With_ProtectedInternalField_From_OtherAssembly();
            source.Set_ProtectedInternalField_In_BaseClass(1);
            source.Set_ProtectedInternalField_In_DerivedClass(2);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<DerivedClass_With_ProtectedInternalField_From_OtherAssembly>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Equal(source.Get_ProtectedInternalField_In_DerivedClass(), cloned.Get_ProtectedInternalField_In_DerivedClass());
            Assert.Equal(source.Get_ProtectedInternalField_In_BaseClass(), cloned.Get_ProtectedInternalField_In_BaseClass());
        }
    }
}