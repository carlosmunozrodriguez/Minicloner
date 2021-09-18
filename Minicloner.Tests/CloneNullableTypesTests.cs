using Xunit;

namespace Minicloner.Tests
{
    public class CloneNullableTypesTests
    {
        [Fact]
        public void Clone_NullInt32()
        {
            int? nullInt32 = null;
            // ReSharper disable once ExpressionIsAlwaysNull - We want to clone a nullable object
            var cloned = new Cloner().Clone(nullInt32);

            Assert.Null(cloned);
        }

        [Fact]
        public void Clone_NotNullInt32()
        {
            int? notNullInt32 = 1;
            var cloned = new Cloner().Clone(notNullInt32);

            Assert.IsType<int>(cloned);
            Assert.Equal(notNullInt32, cloned);
        }
    }
}