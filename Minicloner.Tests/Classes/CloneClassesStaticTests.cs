using Minicloner.Tests.Fakes;
using Minicloner.Tests.Fakes.Static;
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

            Assert.Same(value, Class_With_InternalStaticReferenceTypeField.Get_InternalStaticReferenceTypeField());
        }

        [Fact]
        public void DontClone_ProtectedInternalStaticReferenceTypeField()
        {
            var value = new EmptyClass();
            var source = new Class_With_ProtectedInternalStaticReferenceTypeField(value);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_ProtectedInternalStaticReferenceTypeField>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Same(value, Class_With_ProtectedInternalStaticReferenceTypeField.Get_ProtectedInternalStaticReferenceTypeField());
        }

        [Fact]
        public void DontClone_PrivateProtectedStaticReferenceTypeField()
        {
            var value = new EmptyClass();
            var source = new Class_With_PrivateProtectedStaticReferenceTypeField(value);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_PrivateProtectedStaticReferenceTypeField>(cloned);
            Assert.NotSame(source, cloned);

            Assert.Same(value, Class_With_PrivateProtectedStaticReferenceTypeField.Get_PrivateProtectedStaticReferenceTypeField());
        }
    }
}