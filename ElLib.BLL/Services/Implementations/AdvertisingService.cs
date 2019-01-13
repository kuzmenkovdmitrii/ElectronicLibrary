using System.Collections.Generic;
using ElLib.BLL.AdvSevice;
using ElLib.BLL.WCF;
using ElLib.Common.Entities.WCF;
using ElLib.Common.Exception;

namespace ElLib.BLL.Services.Implementations
{
    public class AdvertisingService : Interfaces.IAdvertisingService
    {
        private IAdvertisingService channel;

        public AdvertisingService()
        {
            channel = InitializeChannel.CreateChannel();
        }

        public IEnumerable<Advertising> GetRandomByCount(int count)
        {
            ThrowException.CheckNull(count);

            return channel.GetRandomByCount(count);
        }
    }
}
