namespace Minicloner.Tests.Fakes.Fields
{
    public class Class_With_InternalField
    {
        internal readonly int InternalField;

        public Class_With_InternalField(int value) => InternalField = value;

        public int Get_InternalField() => InternalField;
    }
}