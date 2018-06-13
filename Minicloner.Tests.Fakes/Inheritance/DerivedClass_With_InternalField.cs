namespace Minicloner.Tests.Fakes.Inheritance
{
    public class DerivedClass_With_InternalField : EmptyBaseClass
    {
        internal readonly int InternalField;

        public DerivedClass_With_InternalField(int value) => InternalField = value;

        public int Get_InternalField() => InternalField;
    }
}