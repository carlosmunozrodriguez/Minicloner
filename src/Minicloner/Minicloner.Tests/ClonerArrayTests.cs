using System;
using Xunit;

namespace Minicloner.Tests
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

        [Fact]
        public void CloneNon0BasedArray()
        {
            // 1-dimensional array (not vector) has length 5 and index starts in -10.
            // Since it's non 0-based it is not an Int32[] but an Int32[*] with Rank 1
            var array = Array.CreateInstance(typeof(Int32), new[] { 5 }, new[] { -10 });
            var count = 0;
            for (int i = array.GetLowerBound(0); i <= array.GetUpperBound(0); i++)
            {
                array.SetValue(count++, i);
            }
            // array -> [-10]: 0, [-9]: 1, [-8]: 2, [-7]: 3, [-6]: 4

            var cloned = new Cloner().Clone(array);

            // typeof(Int32).MakeArrayType(1) is a multidimensional array with Rank == 1,
            Assert.IsType(typeof(Int32).MakeArrayType(1), cloned);
            Assert.NotSame(array, cloned);
            Assert.Equal(array.Rank, cloned.Rank);
            Assert.Equal(array.Length, cloned.Length);

            for (var i = -10; i <= -6; i++)
            {
                Assert.Equal(array.GetValue(i), cloned.GetValue(i));
            }
        }

        [Fact]
        public void CloneNon0BasedTwoDimensionalArray()
        {
            // 2-dimensional array with lengths 2 and 3 and with indices that starts in -10 and -20.
            var array = Array.CreateInstance(typeof(Int32), new[] { 2, 3 }, new[] { -10, -20 });
            var count = 0;
            for (int i = array.GetLowerBound(0); i <= array.GetUpperBound(0); i++)
            {
                for (int j = array.GetLowerBound(1); j <= array.GetUpperBound(1); j++)
                {
                    array.SetValue(count++, i, j);
                }
            }
            // array -> [-10, -20]: 0, [-10,-19]: 1, [-10,-18]: 2, [-9,-20]: 3, [-9,-19]: 4, [-9,-18]: 5

            var cloned = new Cloner().Clone(array);

            // typeof(Int32).MakeArrayType(2) is a multidimensional array with Rank == 2,
            Assert.IsType(typeof(Int32).MakeArrayType(2), cloned);
            Assert.NotSame(array, cloned);
            Assert.Equal(array.Rank, cloned.Rank);
            Assert.Equal(array.GetLength(0), cloned.GetLength(0));
            Assert.Equal(array.GetLength(1), cloned.GetLength(1));

            for (var i = -10; i <= -9; i++)
            {
                for (int j = -20; j <= -18; j++)
                {
                    Assert.Equal(array.GetValue(i, j), cloned.GetValue(i, j));
                }
            }
        }
    }
}
