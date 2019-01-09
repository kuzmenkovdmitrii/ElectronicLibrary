using System;

namespace ElLib.Common.Exception
{
    public static class ThrowException
    {
        public static void CheckNull(object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }
        }
    }
}
