using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ElLib.Common.Entities.WCF;
using ElLib.Common.Exception;
using ElLib.Common.ProcedureExecuter;
using ElLib.WCF.Converter;
using ElLib.WCF.DAL;

namespace ElLib.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AdvertisingService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AdvertisingService.svc or AdvertisingService.svc.cs at the Solution Explorer and start debugging.
    public class AdvertisingService : IAdvertisingService
    {
        private readonly IAdvertisingRepository repository;

        public AdvertisingService()
        {
            this.repository = new AdvertisingRepository();
        }

        public IEnumerable<Advertising> GetRandomByCount(int count)
        {
            ThrowException.CheckNull(count);

            return repository.GetRandomByCount(count);
        }
    }
}
