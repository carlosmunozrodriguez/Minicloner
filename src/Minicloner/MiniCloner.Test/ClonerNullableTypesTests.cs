using System;
using Xunit;

namespace Minicloner.Tests
{
    public class ClonerNullableTypesTests
    {
        [Fact]
        public void CloneNullInt32()
        {
            Nullable<Int32> nullInt32 = null;
            var cloned = new Cloner().Clone(nullInt32);

            Assert.Null(cloned);
        }

        [Fact]
        public void CloneNotNullInt32()
        {
            Nullable<Int32> notNullInt32 = 1;
            var cloned = new Cloner().Clone(notNullInt32);

            Assert.IsType<Int32>(cloned);
            Assert.NotSame(notNullInt32, cloned);
            Assert.Equal(notNullInt32, cloned);
        }
    }
}
