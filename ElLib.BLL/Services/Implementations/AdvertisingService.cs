using System.Collections.Generic;
using ElLib.BLL.AdvSevice;
using ElLib.BLL.WCF;
using ElLib.Common.Entities.WCF;
using ElLib.Common.Exception;

namespace ElLib.BLL.Services.Implementations
{
    public class AdvertisingService : Interfaces.IAdvertisingService
    {
        private readonly AdvertisingServiceClient client;

        public AdvertisingService()
        {
            client = new AdvertisingServiceClient();
        }

        public IEnumerable<Advertising> GetRandomByCount(int count)
        {
            ThrowException.CheckNull(count);

            return client.GetRandomByCount(count);
        }
    }
}
