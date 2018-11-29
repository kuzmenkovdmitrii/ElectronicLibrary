using System;
using log4net;
using log4net.Config;

namespace ElLib.Common.Logger
{
    public static class Logger
    {
        public static ILog For(object LoggedObject)
        {
            if (LoggedObject != null)
            {
                return For(LoggedObject.GetType());
            }
            else
            {
                return For(null);
            }
        }

        public static ILog For(Type ObjectType)
        {
            if (ObjectType != null)
            {
                return LogManager.GetLogger(ObjectType.Name);
            }
            else
            {
                return LogManager.GetLogger(string.Empty);
            }
        }
    }
}