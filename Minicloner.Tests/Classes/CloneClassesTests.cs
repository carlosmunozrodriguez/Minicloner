using Minicloner.Tests.Fakes;
using Minicloner.Tests.Fakes.AutoImplementedProperties;
using Xunit;

namespace Minicloner.Tests.Classes
{
    public class CloneClassesTests
    {
        [Fact]
        public void Clone_EmptyClass()
        {
            var source = new EmptyClass();
            var cloned = new Cloner().Clone(source);

            Assert.IsType<EmptyClass>(cloned);
            Assert.NotSame(source, cloned);
        }

        [Fact]
        public void Clone_Class_With_ReferenceTypeProperty()
        {
            var source = new Class_With_ReferenceTypeProperty
            {
                ReferenceTypeProperty = new Class_With_PublicAutoImplementedProperty
                {
                    PublicAutoImplementedProperty = 1
                }
            };

            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_ReferenceTypeProperty>(cloned);
            Assert.NotSame(source, cloned);

            Assert.IsType<Class_With_PublicAutoImplementedProperty>(cloned.ReferenceTypeProperty);
            Assert.NotSame(source.ReferenceTypeProperty, cloned.ReferenceTypeProperty);

            Assert.IsType<int>(cloned.ReferenceTypeProperty.PublicAutoImplementedProperty);
            Assert.Equal(source.ReferenceTypeProperty.PublicAutoImplementedProperty, cloned.ReferenceTypeProperty.PublicAutoImplementedProperty);
        }

        [Fact]
        public void Clone_Class_With_TwoLevels_Of_ReferenceTypeProperties()
        {
            var source = new Class_With_TwoLevels_Of_ReferenceTypeProperties
            {
                ReferenceTypeProperty = new Class_With_PublicAutoImplementedProperty
                {
                    PublicAutoImplementedProperty = 1
                },
                TwoLeveled_ReferenceTypeProperty = new Class_With_ReferenceTypeProperty
                {
                    ReferenceTypeProperty = new Class_With_PublicAutoImplementedProperty
                    {
                        PublicAutoImplementedProperty = 2
                    }
                }
            };

            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_TwoLevels_Of_ReferenceTypeProperties>(cloned);
            Assert.NotSame(source, cloned);

            Assert.IsType<Class_With_PublicAutoImplementedProperty>(cloned.ReferenceTypeProperty);
            Assert.NotSame(source.ReferenceTypeProperty, cloned.ReferenceTypeProperty);

            Assert.IsType<int>(cloned.ReferenceTypeProperty.PublicAutoImplementedProperty);
            Assert.Equal(source.ReferenceTypeProperty.PublicAutoImplementedProperty, cloned.ReferenceTypeProperty.PublicAutoImplementedProperty);

            Assert.IsType<Class_With_ReferenceTypeProperty>(cloned.TwoLeveled_ReferenceTypeProperty);
            Assert.NotSame(source.TwoLeveled_ReferenceTypeProperty, cloned.TwoLeveled_ReferenceTypeProperty);

            Assert.IsType<Class_With_PublicAutoImplementedProperty>(cloned.TwoLeveled_ReferenceTypeProperty.ReferenceTypeProperty);
            Assert.NotSame(source.TwoLeveled_ReferenceTypeProperty.ReferenceTypeProperty, cloned.TwoLeveled_ReferenceTypeProperty.ReferenceTypeProperty);

            Assert.IsType<int>(cloned.TwoLeveled_ReferenceTypeProperty.ReferenceTypeProperty.PublicAutoImplementedProperty);
            Assert.Equal(source.TwoLeveled_ReferenceTypeProperty.ReferenceTypeProperty.PublicAutoImplementedProperty, cloned.TwoLeveled_ReferenceTypeProperty.ReferenceTypeProperty.PublicAutoImplementedProperty);
        }

        [Fact]
        public void Clone_Array_With_ReferenceTypeElements()
        {
            Class_With_PublicAutoImplementedProperty[] source =
            {
                new Class_With_PublicAutoImplementedProperty{ PublicAutoImplementedProperty = 1 },
                new Class_With_PublicAutoImplementedProperty{ PublicAutoImplementedProperty = 2 }
            };

            var cloned = new Cloner().Clone(source);

            Assert.IsType<Class_With_PublicAutoImplementedProperty[]>(cloned);
            Assert.NotSame(cloned, source);

            Assert.Equal(2, cloned.Length);
            for (var i = 0; i < cloned.Length; i++)
            {
                Assert.IsType<Class_With_PublicAutoImplementedProperty>(cloned[i]);
                Assert.NotSame(source[i], cloned[i]);

                Assert.IsType<int>(cloned[i].PublicAutoImplementedProperty);
                Assert.Equal(source[i].PublicAutoImplementedProperty, cloned[i].PublicAutoImplementedProperty);
            }
        }
    }
}