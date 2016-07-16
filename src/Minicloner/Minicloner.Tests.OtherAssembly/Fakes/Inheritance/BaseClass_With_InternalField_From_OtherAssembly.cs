using System;

namespace Minicloner.Tests.OtherAssembly.Fakes.Inheritance
{
    public class BaseClass_With_InternalField_From_OtherAssembly
    {
        internal Int32 InternalField_In_BaseClass;

        public void Set_InternalField_In_BaseClass(Int32 int32Parameter)
        {
            InternalField_In_BaseClass = int32Parameter;
        }

        public Int32 Get_InternalField_In_BaseClass() => InternalField_In_BaseClass;
    }
}