using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using Minicloner;
using Xunit;

namespace MiniCloner.Test
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
