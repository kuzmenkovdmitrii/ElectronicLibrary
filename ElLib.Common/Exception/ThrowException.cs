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

        public static void CheckId(int? id)
        {
            if (id == null)
            {
                throw new ArgumentNullException();
            }

            if (id <= 0)
            {
                throw new System.ArgumentException("Argument is negative or 0");
            }
        }
    }
}
