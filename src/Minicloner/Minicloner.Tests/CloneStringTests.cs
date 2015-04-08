using System;
using Xunit;

namespace Minicloner.Tests
{
    public class CloneStringTests
    {
        [Fact]
        public void Clone_NullString()
        {
            const String nullString = null;
            var cloned = new Cloner().Clone(nullString);

            Assert.Null(cloned);
        }

        [Fact]
        public void Clone_EmptyString()
        {
            const String emptyString = "";
            var cloned = new Cloner().Clone(emptyString);

            Assert.IsType<String>(cloned);
            Assert.NotSame(emptyString, cloned);
            Assert.Equal(emptyString, cloned);
        }

        [Fact]
        public void Clone_SomeString()
        {
            const String someString = "qwertyáéíóúñ";
            var cloned = new Cloner().Clone(someString);

            Assert.IsType<String>(cloned);
            Assert.NotSame(someString, cloned);
            Assert.Equal(someString, cloned);
        }
    }
}