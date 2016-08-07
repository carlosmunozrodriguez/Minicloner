using System;
using Xunit;

namespace Minicloner.Tests
{
    public class ClonePrimitiveTypesTests
    {
        [Fact]
        public void Clone_Int16()
        {
            const Int16 someInt16 = 1;
            var cloned = new Cloner().Clone(someInt16);

            Assert.IsType<Int16>(cloned);
            Assert.Equal(someInt16, cloned);
        }

        [Fact]
        public void Clone_Int32()
        {
            const Int32 someInt32 = 1;
            var cloned = new Cloner().Clone(someInt32);

            Assert.IsType<Int32>(cloned);
            Assert.Equal(someInt32, cloned);
        }

        [Fact]
        public void Clone_Int64()
        {
            const Int64 someInt64 = 1;
            var cloned = new Cloner().Clone(someInt64);

            Assert.IsType<Int64>(cloned);
            Assert.Equal(someInt64, cloned);
        }

        [Fact]
        public void Clone_UInt16()
        {
            const UInt16 someInt16 = 1;
            var cloned = new Cloner().Clone(someInt16);

            Assert.IsType<UInt16>(cloned);
            Assert.Equal(someInt16, cloned);
        }

        [Fact]
        public void Clone_UInt32()
        {
            const UInt32 someUInt32 = 1;
            var cloned = new Cloner().Clone(someUInt32);

            Assert.IsType<UInt32>(cloned);
            Assert.Equal(someUInt32, cloned);
        }

        [Fact]
        public void Clone_UInt64()
        {
            const UInt64 someUInt64 = 1;
            var cloned = new Cloner().Clone(someUInt64);

            Assert.IsType<UInt64>(cloned);
            Assert.Equal(someUInt64, cloned);
        }

        [Fact]
        public void Clone_Byte()
        {
            const Byte someByte = 1;
            var cloned = new Cloner().Clone(someByte);

            Assert.IsType<Byte>(cloned);
            Assert.Equal(someByte, cloned);
        }

        [Fact]
        public void Clone_SByte()
        {
            const SByte someSByte = 1;
            var cloned = new Cloner().Clone(someSByte);

            Assert.IsType<SByte>(cloned);
            Assert.Equal(someSByte, cloned);
        }

        [Fact]
        public void Clone_Char()
        {
            const Char someChar = 'A';
            var cloned = new Cloner().Clone(someChar);

            Assert.IsType<Char>(cloned);
            Assert.Equal(someChar, cloned);
        }

        [Fact]
        public void Clone_Single()
        {
            const Single someSingle = 1f;
            var cloned = new Cloner().Clone(someSingle);

            Assert.IsType<Single>(cloned);
            Assert.Equal(someSingle, cloned);
        }

        [Fact]
        public void Clone_Double()
        {
            const Double someDouble = 1d;
            var cloned = new Cloner().Clone(someDouble);

            Assert.IsType<Double>(cloned);
            Assert.Equal(someDouble, cloned);
        }

        [Fact]
        public void Clone_Boolean()
        {
            const Boolean someBoolean = true;
            var cloned = new Cloner().Clone(someBoolean);

            Assert.IsType<Boolean>(cloned);
            Assert.Equal(someBoolean, cloned);
        }

        // Decimal is not exactly primitive but a common type
        [Fact]
        public void Clone_Decimal()
        {
            const decimal someDecimal = 1m;
            var cloned = new Cloner().Clone(someDecimal);

            Assert.IsType<Decimal>(cloned);
            Assert.Equal(someDecimal, cloned);
        }
    }
}