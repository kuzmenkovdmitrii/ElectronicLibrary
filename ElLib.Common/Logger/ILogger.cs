using System;
using log4net;

namespace ElLib.Common.Logger
{
    public interface ILogger
    {
        void Error(string message);
        ILog For(object LoggedObject);
        ILog For(Type ObjectType);
    }
}
