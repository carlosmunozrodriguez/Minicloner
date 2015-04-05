using System;
using System.Collections.Generic;
using Minicloner;
using Xunit;

namespace MiniCloner.Test
{
    public class ClonerArrayTests
    {
        [Fact]
        public void CloneEmptyInt32Array()
        {
            Int32[] array = { };
            var cloned = new Cloner().Clone(array);

            Assert.IsType<Int32[]>(cloned);
            Assert.NotSame(array, cloned);
            Assert.Empty(cloned);
        }

        [Fact]
        public void CloneNonEmptyInt32ArrayWithElements()
        {
            Int32[] array = { 1, 2, 3, 4, 5 };
            var cloned = new Cloner().Clone(array);

            Assert.IsType<Int32[]>(cloned);
            Assert.NotSame(array, cloned);
            Assert.Equal(array.Length, cloned.Length);
            for (int i = 0; i < array.Length; i++)
            {
                Assert.Equal(array[i], cloned[i]);
            }
        }
    }
}
