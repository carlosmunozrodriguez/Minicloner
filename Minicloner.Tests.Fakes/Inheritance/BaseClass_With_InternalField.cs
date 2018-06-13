namespace Minicloner.Tests.Fakes.Inheritance
{
    public class BaseClass_With_InternalField
    {
        internal readonly int InternalField;

        public BaseClass_With_InternalField(int value) => InternalField = value;

        public int Get_InternalField() => InternalField;
    }
}