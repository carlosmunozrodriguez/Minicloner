using System;
using Minicloner.Tests.Fakes;
using Xunit;

namespace Minicloner.Tests
{
    public class CloneClassesTests
    {
        [Fact]
        public void CloneEmptyClass()
        {
            var emptyClass = new EmptyClass();
            var cloned = new Cloner().Clone(emptyClass);

            Assert.IsType<EmptyClass>(cloned);
            Assert.NotSame(emptyClass, cloned);
        }

        [Fact]
        public void CloneClassWithPublicField()
        {
            var classWithPublicField = new ClassWithPublicValueTypeField { PublicInt32Field = 1 };
            var cloned = new Cloner().Clone(classWithPublicField);

            Assert.IsType<ClassWithPublicValueTypeField>(cloned);
            Assert.NotSame(classWithPublicField, cloned);
            Assert.Equal(classWithPublicField.PublicInt32Field, cloned.PublicInt32Field);
        }

        [Fact]
        public void CloneClassWithoutParameterlessConstructor()
        {
            var source = new ClassWithoutParameterlessConstructor(null);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<ClassWithoutParameterlessConstructor>(cloned);
            Assert.NotSame(source, cloned);
        }

        [Fact]
        public void CloneClassWithPrivateValueTypeField()
        {
            var classWithPrivateField = new ClassWithPrivateValueTypeField(1);
            var cloned = new Cloner().Clone(classWithPrivateField);

            Assert.IsType<ClassWithPrivateValueTypeField>(cloned);
            Assert.NotSame(classWithPrivateField, cloned);
            Assert.Equal(classWithPrivateField.GetPrivateFieldValue(), cloned.GetPrivateFieldValue());
        }

        [Fact]
        public void CloneClassWithPublicAutomaticallyImplementedProperty()
        {
            var source = new ClassWithPublicAutomaticallyImplementedProperty { PublicInt32Property = 1 };
            var cloned = new Cloner().Clone(source);

            Assert.IsType<ClassWithPublicAutomaticallyImplementedProperty>(cloned);
            Assert.NotSame(source, cloned);
            Assert.Equal(source.PublicInt32Property, cloned.PublicInt32Property);
        }

        [Fact]
        public void CloneClassWithPrivateSetter()
        {
            var source = new ClassWithPrivateSetter();
            source.SetInt32PropertyWithPrivateSetter(1);
            var cloned = new Cloner().Clone(source);

            Assert.IsType<ClassWithPrivateSetter>(cloned);
            Assert.NotSame(source, cloned);
            Assert.Equal(source.Int32PropertyWithPrivateSetter, cloned.Int32PropertyWithPrivateSetter);
        }

        [Fact]
        public void CloneClassWithPrivateGetter()
        {
            var source = new ClassWithPrivateGetter { Int32PropertyWithPrivateGetter = 1 };
            var cloned = new Cloner().Clone(source);

            Assert.IsType<ClassWithPrivateGetter>(cloned);
            Assert.NotSame(source, cloned);
            Assert.Equal(source.GetInt32PropertyWithPrivateSetter(), cloned.GetInt32PropertyWithPrivateSetter());
        }

        [Fact]
        public void CloneClassWithReferenceTypeProperty()
        {
            var source = new ClassWithReferenceTypeProperty
            {
                ReferenceTypeProperty = new ClassWithPublicAutomaticallyImplementedProperty
                {
                    PublicInt32Property = 1
                }
            };

            var cloned = new Cloner().Clone(source);

            Assert.IsType<ClassWithReferenceTypeProperty>(cloned);
            Assert.NotSame(source, cloned);

            Assert.IsType<ClassWithPublicAutomaticallyImplementedProperty>(cloned.ReferenceTypeProperty);
            Assert.NotSame(source.ReferenceTypeProperty, cloned.ReferenceTypeProperty);

            Assert.IsType<Int32>(cloned.ReferenceTypeProperty.PublicInt32Property);
            Assert.Equal(source.ReferenceTypeProperty.PublicInt32Property, cloned.ReferenceTypeProperty.PublicInt32Property);
        }

        [Fact]
        public void CloneClassWithTwoLevelsOfReferenceTypeProperties()
        {
            var source = new ClassWithTwoLevelsOfReferenceTypeProperties
            {
                ReferenceTypeProperty = new ClassWithPublicAutomaticallyImplementedProperty
                {
                    PublicInt32Property = 1
                },
                TwoLeveledReferenceTypeProperty = new ClassWithReferenceTypeProperty
                {
                    ReferenceTypeProperty = new ClassWithPublicAutomaticallyImplementedProperty
                    {
                        PublicInt32Property = 2
                    }
                }
            };

            var cloned = new Cloner().Clone(source);

            Assert.IsType<ClassWithTwoLevelsOfReferenceTypeProperties>(cloned);
            Assert.NotSame(source, cloned);

            Assert.IsType<ClassWithPublicAutomaticallyImplementedProperty>(cloned.ReferenceTypeProperty);
            Assert.NotSame(source.ReferenceTypeProperty, cloned.ReferenceTypeProperty);

            Assert.IsType<Int32>(cloned.ReferenceTypeProperty.PublicInt32Property);
            Assert.Equal(source.ReferenceTypeProperty.PublicInt32Property, cloned.ReferenceTypeProperty.PublicInt32Property);

            Assert.IsType<ClassWithReferenceTypeProperty>(cloned.TwoLeveledReferenceTypeProperty);
            Assert.NotSame(source.TwoLeveledReferenceTypeProperty, cloned.TwoLeveledReferenceTypeProperty);

            Assert.IsType<ClassWithPublicAutomaticallyImplementedProperty>(cloned.TwoLeveledReferenceTypeProperty.ReferenceTypeProperty);
            Assert.NotSame(source.TwoLeveledReferenceTypeProperty.ReferenceTypeProperty, cloned.TwoLeveledReferenceTypeProperty.ReferenceTypeProperty);

            Assert.IsType<Int32>(cloned.TwoLeveledReferenceTypeProperty.ReferenceTypeProperty.PublicInt32Property);
            Assert.Equal(source.TwoLeveledReferenceTypeProperty.ReferenceTypeProperty.PublicInt32Property, cloned.TwoLeveledReferenceTypeProperty.ReferenceTypeProperty.PublicInt32Property);
        }

        [Fact]
        public void CloneArrayWithReferenceTypeElements()
        {
            ClassWithPublicAutomaticallyImplementedProperty[] source =
            {
                new ClassWithPublicAutomaticallyImplementedProperty{ PublicInt32Property = 1 }, 
                new ClassWithPublicAutomaticallyImplementedProperty{ PublicInt32Property = 2 } 
            };

            var cloned = new Cloner().Clone(source);

            Assert.IsType<ClassWithPublicAutomaticallyImplementedProperty[]>(cloned);
            Assert.NotSame(cloned, source);

            Assert.Equal(2, cloned.Length);
            for (var i = 0; i < cloned.Length; i++)
            {
                Assert.IsType<ClassWithPublicAutomaticallyImplementedProperty>(cloned[i]);
                Assert.NotSame(source[i], cloned[i]);

                Assert.IsType<Int32>(cloned[i].PublicInt32Property);
                Assert.Equal(source[i].PublicInt32Property, cloned[i].PublicInt32Property);
            }
        }
    }
}