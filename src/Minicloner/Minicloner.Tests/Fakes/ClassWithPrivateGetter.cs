using System;

namespace Minicloner.Tests.Fakes
{
    public class ClassWithPrivateGetter
    {
        public Int32 Int32PropertyWithPrivateGetter { private get; set; }

        public Int32 GetInt32PropertyWithPrivateSetter()
        {
            return Int32PropertyWithPrivateGetter;
        }
    }
}