using System;
using Xunit;

namespace Minicloner.Tests
{
    public class CloneIntPtrTests
    {
        [Fact]
        public void Clone_IntPtr()
        {
            var someIntPtr = (IntPtr)1;
            var cloned = new Cloner().Clone(someIntPtr);

            Assert.IsType<IntPtr>(cloned);
            Assert.Equal(someIntPtr, cloned);
        }

        [Fact]
        public void Clone_UIntPtr()
        {
            var someUIntPtr = (UIntPtr)1;
            var cloned = new Cloner().Clone(someUIntPtr);

            Assert.IsType<UIntPtr>(cloned);
            Assert.Equal(someUIntPtr, cloned);
        }
    }
}