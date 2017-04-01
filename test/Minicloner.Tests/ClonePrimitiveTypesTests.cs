using Xunit;

namespace Minicloner.Tests
{
    public class ClonePrimitiveTypesTests
    {
        [Fact]
        public void Clone_Int16()
        {
            const short someInt16 = 1;
            var cloned = new Cloner().Clone(someInt16);

            Assert.IsType<short>(cloned);
            Assert.Equal(someInt16, cloned);
        }

        [Fact]
        public void Clone_Int32()
        {
            const int someInt32 = 1;
            var cloned = new Cloner().Clone(someInt32);

            Assert.IsType<int>(cloned);
            Assert.Equal(someInt32, cloned);
        }

        [Fact]
        public void Clone_Int64()
        {
            const long someInt64 = 1;
            var cloned = new Cloner().Clone(someInt64);

            Assert.IsType<long>(cloned);
            Assert.Equal(someInt64, cloned);
        }

        [Fact]
        public void Clone_UInt16()
        {
            const ushort someInt16 = 1;
            var cloned = new Cloner().Clone(someInt16);

            Assert.IsType<ushort>(cloned);
            Assert.Equal(someInt16, cloned);
        }

        [Fact]
        public void Clone_UInt32()
        {
            const uint someUInt32 = 1;
            var cloned = new Cloner().Clone(someUInt32);

            Assert.IsType<uint>(cloned);
            Assert.Equal(someUInt32, cloned);
        }

        [Fact]
        public void Clone_UInt64()
        {
            const ulong someUInt64 = 1;
            var cloned = new Cloner().Clone(someUInt64);

            Assert.IsType<ulong>(cloned);
            Assert.Equal(someUInt64, cloned);
        }

        [Fact]
        public void Clone_Byte()
        {
            const byte someByte = 1;
            var cloned = new Cloner().Clone(someByte);

            Assert.IsType<byte>(cloned);
            Assert.Equal(someByte, cloned);
        }

        [Fact]
        public void Clone_SByte()
        {
            const sbyte someSByte = 1;
            var cloned = new Cloner().Clone(someSByte);

            Assert.IsType<sbyte>(cloned);
            Assert.Equal(someSByte, cloned);
        }

        [Fact]
        public void Clone_Char()
        {
            const char someChar = 'A';
            var cloned = new Cloner().Clone(someChar);

            Assert.IsType<char>(cloned);
            Assert.Equal(someChar, cloned);
        }

        [Fact]
        public void Clone_Single()
        {
            const float someSingle = 1f;
            var cloned = new Cloner().Clone(someSingle);

            Assert.IsType<float>(cloned);
            Assert.Equal(someSingle, cloned);
        }

        [Fact]
        public void Clone_Double()
        {
            const double someDouble = 1d;
            var cloned = new Cloner().Clone(someDouble);

            Assert.IsType<double>(cloned);
            Assert.Equal(someDouble, cloned);
        }

        [Fact]
        public void Clone_Boolean()
        {
            const bool someBoolean = true;
            var cloned = new Cloner().Clone(someBoolean);

            Assert.IsType<bool>(cloned);
            Assert.Equal(someBoolean, cloned);
        }

        // Decimal is not exactly primitive but a common type
        [Fact]
        public void Clone_Decimal()
        {
            const decimal someDecimal = 1m;
            var cloned = new Cloner().Clone(someDecimal);

            Assert.IsType<decimal>(cloned);
            Assert.Equal(someDecimal, cloned);
        }
    }
}