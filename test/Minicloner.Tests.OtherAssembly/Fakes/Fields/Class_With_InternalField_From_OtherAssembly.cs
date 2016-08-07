using System;

namespace Minicloner.Tests.OtherAssembly.Fakes.Fields
{
    public class Class_With_InternalField_From_OtherAssembly
    {
        internal Int32 InternalField;

        public Class_With_InternalField_From_OtherAssembly(Int32 parameter)
        {
            InternalField = parameter;
        }

        public Int32 Get_InternalField() => InternalField;
    }
}