using log4net;

namespace ElLib.Common.Logger
{
    public class Logger
    {
        //static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public static ILog Log
        {
            get
            {
                var logger = LogManager.GetLogger("CustomLogger");
                return logger;
            }
        }
    }
}