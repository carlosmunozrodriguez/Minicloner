using Minicloner.Tests.Fakes;
using Minicloner.Tests.Fakes.Static;
using Minicloner.Tests.OtherAssembly.Fakes;
using Minicloner.Tests.OtherAssembly.Fakes.Static;
using Xunit;

namespace Minicloner.Tests.Classes
{
    public class CloneClassesStaticTests
    {
        [Fact]
        public void DontClone_PublicStaticReferenceTypeField()
        {
            var value = new EmptyClass();
            var source = new Class_With_PublicStaticReferenceTypeField(value);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_PublicStaticReferenceTypeField>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Same(value, Class_With_PublicStaticReferenceTypeField.PublicStaticReferenceTypeField);
        }

        [Fact]
        public void DontClone_PrivateStaticReferenceTypeField()
        {
            var value = new EmptyClass();
            var source = new Class_With_PrivateStaticReferenceTypeField(value);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_PrivateStaticReferenceTypeField>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Same(value, Class_With_PrivateStaticReferenceTypeField.Get_PrivateStaticReferenceTypeProperty());
        }

        [Fact]
        public void DontClone_ProtectedStaticReferenceTypeField()
        {
            var value = new EmptyClass();
            var source = new Class_With_ProtectedStaticReferenceTypeField(value);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_ProtectedStaticReferenceTypeField>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Same(value, Class_With_ProtectedStaticReferenceTypeField.Get_ProtectedStaticReferenceTypeProperty());
        }

        [Fact]
        public void DontClone_InternalStaticReferenceTypeField()
        {
            var value = new EmptyClass();
            var source = new Class_With_InternalStaticReferenceTypeField(value);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_InternalStaticReferenceTypeField>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Same(value, Class_With_InternalStaticReferenceTypeField.InternalStaticReferenceTypeField);
        }

        [Fact]
        public void DontClone_InternalStaticReferenceTypeField_From_OtherAssembly()
        {
            var value = new EmptyClass_From_OtherAssembly();
            var source = new Class_With_InternalStaticReferenceTypeField_From_OtherAssembly(value);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_InternalStaticReferenceTypeField_From_OtherAssembly>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Same(value, Class_With_InternalStaticReferenceTypeField_From_OtherAssembly.Get_InternalStaticReferenceTypeField());
        }

        [Fact]
        public void DontClone_ProtectedInternalStaticReferenceTypeField()
        {
            var value = new EmptyClass();
            var source = new Class_With_ProtectedInternalStaticReferenceTypeField(value);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_ProtectedInternalStaticReferenceTypeField>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Same(value, Class_With_ProtectedInternalStaticReferenceTypeField.ProtectedInternalStaticReferenceTypeField);
        }

        [Fact]
        public void DontClone_ProtectedInternalStaticReferenceTypeField_From_OtherAssembly()
        {
            var value = new EmptyClass_From_OtherAssembly();
            var source = new Class_With_ProtectedInternalStaticReferenceTypeField_From_OtherAssembly(value);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_ProtectedInternalStaticReferenceTypeField_From_OtherAssembly>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Same(value, Class_With_ProtectedInternalStaticReferenceTypeField_From_OtherAssembly.Get_ProtectedInternalStaticReferenceTypeField());
        }
    }
}