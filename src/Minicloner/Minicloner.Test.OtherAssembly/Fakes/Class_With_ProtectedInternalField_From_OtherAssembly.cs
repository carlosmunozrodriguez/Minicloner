using System;

namespace Minicloner.Test.OtherAssembly.Fakes
{
    public class Class_With_ProtectedInternalField_From_OtherAssembly
    {
        protected internal Int32 ProtectedInternalField;

        public Class_With_ProtectedInternalField_From_OtherAssembly(Int32 parameter)
        {
            ProtectedInternalField = parameter;
        }

        public Int32 Get_ProtectedInternalField()
        {
            return ProtectedInternalField;
        }
    }
}