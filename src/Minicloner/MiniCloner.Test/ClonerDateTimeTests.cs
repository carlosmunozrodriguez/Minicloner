using System;
using Minicloner;
using Xunit;

namespace MiniCloner.Test
{
    public class ClonerDateTimeTests
    {
        [Fact]
        public void CloneDefaultDateTime()
        {
            var dateTime = new DateTime();
            var cloned = new Cloner().Clone(dateTime);

            Assert.IsType<DateTime>(cloned);
            Assert.Equal(dateTime, cloned);
        }

        [Fact]
        public void CloneDateTimeNow()
        {
            var dateTime = DateTime.Now;
            var cloned = new Cloner().Clone(dateTime);

            Assert.IsType<DateTime>(cloned);
            Assert.Equal(dateTime, cloned);
        }
    }
}
