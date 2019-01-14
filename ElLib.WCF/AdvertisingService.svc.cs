using System.Collections.Generic;
using ElLib.Common.Entities.WCF;
using ElLib.Common.Exception;
using ElLib.WCF.DAL;

namespace ElLib.WCF
{
    public class AdvertisingService : IAdvertisingService
    {
        private readonly IAdvertisingRepository repository;

        public AdvertisingService()
        {
            repository = new AdvertisingRepository();
        }

        public IEnumerable<Advertising> GetRandomByCount(int count)
        {
            ThrowException.CheckNull(count);

            return repository.GetRandomByCount(count);
        }
    }
}
