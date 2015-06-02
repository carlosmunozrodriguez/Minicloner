using Minicloner.Tests.Fakes.CircularReference;
using Xunit;

namespace Minicloner.Tests.Classes
{
    public class CloneClassesCircularReferenceTests
    {
        [Fact]
        public void Clone_ReflexiveClass()
        {
            var source = new ReflexiveClass(1);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<ReflexiveClass>(cloned);
            Assert.NotSame(source, cloned);
            Assert.Equal(source.Int32Property, cloned.Int32Property);

            Assert.IsType<ReflexiveClass>(cloned.Self);
            Assert.Same(cloned, cloned.Self);
        }

        [Fact]
        public void Clone_MutuallyDependentClasses()
        {
            var sourceA = new MutuallyDependentClassA(1);
            var sourceB = new MutuallyDependentClassB(2) { A = sourceA };
            sourceA.B = sourceB;

            var clonedA = new Cloner().Clone(sourceA);

            Assert.IsType<MutuallyDependentClassA>(clonedA);
            Assert.NotSame(sourceA, clonedA);
            Assert.Equal(sourceA.Int32Property, clonedA.Int32Property);

            var clonedB = clonedA.B;
            Assert.IsType<MutuallyDependentClassB>(clonedB);
            Assert.NotSame(sourceB, clonedB);
            Assert.Equal(sourceB.Int32Property, clonedB.Int32Property);

            Assert.Same(clonedA, clonedB.A);
        }
    }
}
