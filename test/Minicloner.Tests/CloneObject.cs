using Xunit;

namespace Minicloner.Tests
{
    public class CloneObject
    {
        [Fact]
        public void Clone_NullObject()
        {
            object nullObject = null;
            var cloned = new Cloner().Clone(nullObject);

            Assert.Null(cloned);
        }

        [Fact]
        public void Clone_NotNullObject()
        {
            var notNullObject = new object();
            var cloned = new Cloner().Clone(notNullObject);

            Assert.IsType<object>(cloned);
            Assert.NotSame(notNullObject, cloned);
        }
    }
}