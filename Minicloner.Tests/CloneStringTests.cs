using Xunit;

namespace Minicloner.Tests
{
    public class CloneStringTests
    {
        [Fact]
        public void Clone_NullString()
        {
            const string nullString = null;
            var cloned = new Cloner().Clone(nullString);

            Assert.Null(cloned);
        }

        [Fact]
        public void Clone_EmptyString()
        {
            const string emptyString = "";
            var cloned = new Cloner().Clone(emptyString);

            Assert.IsType<string>(cloned);
            Assert.NotSame(emptyString, cloned);
            Assert.Equal(emptyString, cloned);
        }

        [Fact]
        public void Clone_SomeString()
        {
            const string someString = "qwertyáéíóúñ";
            var cloned = new Cloner().Clone(someString);

            Assert.IsType<string>(cloned);
            Assert.NotSame(someString, cloned);
            Assert.Equal(someString, cloned);
        }
    }
}