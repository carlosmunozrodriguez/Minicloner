using System;
using Minicloner.Tests.Fakes.Fields;
using Xunit;

namespace Minicloner.Tests
{
    public class CloneValueTupleTests
    {
        [Fact]
        public void Clone_ValueTypeItemValueTuple()
        {
            var tuple = new ValueTuple<int>(1);
            var cloned = new Cloner().Clone(tuple);

            Assert.IsType<ValueTuple<int>>(cloned);
            Assert.Equal(tuple, cloned);
        }

        [Fact]
        public void Clone_StringItemValueTuple()
        {
            var tuple = new ValueTuple<string>("Hello");
            var cloned = new Cloner().Clone(tuple);

            Assert.IsType<ValueTuple<string>>(cloned);
            Assert.Equal(tuple, cloned);
        }

        [Fact]
        public void Clone_TwoItemsValueTuple()
        {
            var tuple = (1, "Hello");
            var cloned = new Cloner().Clone(tuple);

            Assert.IsType<ValueTuple<int, string>>(cloned);
            Assert.Equal(tuple, cloned);
        }

        [Fact]
        public void Clone_ClassValueTuple()
        {
            var tuple = new ValueTuple<Class_With_PublicField>(new Class_With_PublicField
            {
                PublicField = 1
            });
            var cloned = new Cloner().Clone(tuple);

            Assert.IsType<ValueTuple<Class_With_PublicField>>(cloned);
            Assert.NotSame(tuple.Item1, cloned.Item1);
            Assert.Equal(tuple.Item1.PublicField, cloned.Item1.PublicField);
        }
    }
}