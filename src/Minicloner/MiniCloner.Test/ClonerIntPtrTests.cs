using System;
using Minicloner;
using Xunit;

namespace MiniCloner.Test
{
    public class ClonerIntPtrTests
    {
        [Fact]
        public void CloneIntPtr()
        {
            var someIntPtr = (IntPtr)1;
            var cloned = new Cloner().Clone(someIntPtr);

            Assert.IsType<IntPtr>(cloned);
            Assert.Equal(someIntPtr, cloned);
        }

        [Fact]
        public void CloneUIntPtr()
        {
            var someUIntPtr = (UIntPtr)1;
            var cloned = new Cloner().Clone(someUIntPtr);

            Assert.IsType<UIntPtr>(cloned);
            Assert.Equal(someUIntPtr, cloned);
        }
    }
}
