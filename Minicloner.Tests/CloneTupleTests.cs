using Minicloner.Tests.Fakes.Fields;
using System;
using Xunit;

namespace Minicloner.Tests
{
    public class CloneTupleTests
    {
        [Fact]
        public void Clone_ValueTypeItemTuple()
        {
            var tuple = new Tuple<int>(1);
            var cloned = new Cloner().Clone(tuple);

            Assert.IsType<Tuple<int>>(cloned);
            Assert.NotSame(tuple, cloned);
            Assert.Equal(tuple, cloned);
        }

        [Fact]
        public void Clone_StringItemTuple()
        {
            var tuple = new Tuple<string>("Hello");
            var cloned = new Cloner().Clone(tuple);

            Assert.IsType<Tuple<string>>(cloned);
            Assert.NotSame(tuple, cloned);
            Assert.Equal(tuple, cloned);
        }

        [Fact]
        public void Clone_TwoItemsTuple()
        {
            var tuple = new Tuple<int, string>(1, "Hello");
            var cloned = new Cloner().Clone(tuple);

            Assert.IsType<Tuple<int, string>>(cloned);
            Assert.NotSame(tuple, cloned);
            Assert.Equal(tuple, cloned);
        }

        [Fact]
        public void Clone_ClassTuple()
        {
            var tuple = new Tuple<Class_With_PublicField>(new Class_With_PublicField
            {
                PublicField = 1
            });
            var cloned = new Cloner().Clone(tuple);

            Assert.IsType<Tuple<Class_With_PublicField>>(cloned);
            Assert.NotSame(tuple, cloned);
            Assert.Equal(tuple.Item1.PublicField, cloned.Item1.PublicField);
        }
    }
}