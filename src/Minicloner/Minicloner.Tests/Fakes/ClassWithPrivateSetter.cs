using System;

namespace Minicloner.Tests.Fakes
{
    public class ClassWithPrivateSetter
    {
        public Int32 Int32PropertyWithPrivateSetter { get; private set; }

        public void SetInt32PropertyWithPrivateSetter(Int32 int32Parameter)
        {
            Int32PropertyWithPrivateSetter = int32Parameter;
        }
    }
}