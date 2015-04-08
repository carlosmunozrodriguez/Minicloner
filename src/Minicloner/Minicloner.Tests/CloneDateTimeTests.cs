using System;
using Xunit;

namespace Minicloner.Tests
{
    public class CloneDateTimeTests
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