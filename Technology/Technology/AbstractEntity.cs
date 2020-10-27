using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public abstract class AbstractEntity
    {
        internal static int objectIDnumber = -1;

        public abstract int GetObjectId();
    }
}
