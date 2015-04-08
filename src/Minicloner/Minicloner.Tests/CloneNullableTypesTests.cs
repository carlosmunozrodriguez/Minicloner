using System;
using Xunit;

namespace Minicloner.Tests
{
    public class CloneNullableTypesTests
    {
        [Fact]
        public void Clone_NullInt32()
        {
            Nullable<Int32> nullInt32 = null;
            var cloned = new Cloner().Clone(nullInt32);

            Assert.Null(cloned);
        }

        [Fact]
        public void Clone_NotNullInt32()
        {
            Nullable<Int32> notNullInt32 = 1;
            var cloned = new Cloner().Clone(notNullInt32);

            Assert.IsType<Int32>(cloned);
            Assert.NotSame(notNullInt32, cloned);
            Assert.Equal(notNullInt32, cloned);
        }
    }
}