using System;
using System.Collections.Generic;
using System.Linq;
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
            Assert.Equal(array.Rank, cloned.Rank);
            Assert.Equal(array.Length, cloned.Length);

            for (var i = 0; i < array.Length; i++)
            {
                Assert.Equal(array[i], cloned[i]);
            }
        }

        [Fact]
        public void CloneTwoDimensionalArray()
        {
            Int32[,] array2D = {
                                { 1, 2 },
                                { 3, 4 },
                                { 5, 6 }
                               };
            var cloned = new Cloner().Clone(array2D);

            Assert.IsType<Int32[,]>(cloned);
            Assert.NotSame(array2D, cloned);
            Assert.Equal(array2D.Rank, cloned.Rank);
            Assert.Equal(array2D.GetLength(0), cloned.GetLength(0));
            Assert.Equal(array2D.GetLength(1), cloned.GetLength(1));

            for (var i = 0; i < array2D.GetLength(0); i++)
            {
                for (var j = 0; j < array2D.GetLength(1); j++)
                {
                    Assert.Equal(array2D[i, j], cloned[i, j]);
                }
            }
        }

        [Fact]
        public void CloneThreeDimensionalArray()
        {
            Int32[, ,] array3D = {
                                { { 1, 2 }, { 3, 4 }, { 5, 6 } },
                                { { 7, 8 }, { 9, 10 }, { 11, 12 } },
                                { { 13, 14 }, { 15, 16 }, { 17, 18 } },
                                { { 19, 20 }, { 21, 22 }, { 23, 24 } }
                               };
            var cloned = new Cloner().Clone(array3D);

            Assert.IsType<Int32[, ,]>(cloned);
            Assert.NotSame(array3D, cloned);
            Assert.Equal(array3D.Rank, cloned.Rank);
            Assert.Equal(array3D.GetLength(0), cloned.GetLength(0));
            Assert.Equal(array3D.GetLength(1), cloned.GetLength(1));
            Assert.Equal(array3D.GetLength(2), cloned.GetLength(2));

            for (var i = 0; i < array3D.GetLength(0); i++)
            {
                for (var j = 0; j < array3D.GetLength(1); j++)
                {
                    for (var k = 0; k < array3D.GetLength(2); k++)
                    {
                        Assert.Equal(array3D[i, j, k], cloned[i, j, k]);
                    }
                }
            }
        }
    }
}
