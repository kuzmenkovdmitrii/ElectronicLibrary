using System;
using log4net;

namespace ElLib.Common.Logger
{
    public class Logger : ILogger
    {
        private readonly ILog logger;

        public Logger()
        {
            logger = LogManager.GetLogger("ElLibLogger");
        }

        public void Error(string message)
        {
            logger.Error(message);
        }

        public ILog For(object LoggedObject)
        {
            if (LoggedObject != null)
            {
                return For(LoggedObject.GetType());
            }

            return For(null);
        }

        public ILog For(Type ObjectType)
        {
            if (ObjectType != null)
            {
                return LogManager.GetLogger(ObjectType.Name);
            }

            return LogManager.GetLogger(string.Empty);
        }
    }
}