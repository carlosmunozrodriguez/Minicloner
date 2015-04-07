using Xunit;

namespace Minicloner.Tests
{
    public class ClonerObject
    {
        [Fact]
        public void CloneNullObject()
        {
            object nullObject = null;
            var cloned = new Cloner().Clone(nullObject);

            Assert.Null(cloned);
        }

        [Fact]
        public void CloneNotNullObject()
        {
            object notNullObject = new object();
            var cloned = new Cloner().Clone(notNullObject);

            Assert.IsType<object>(cloned);
            Assert.NotSame(notNullObject, cloned);
        }
    }
}
