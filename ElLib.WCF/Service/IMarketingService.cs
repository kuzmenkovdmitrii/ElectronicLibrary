using System.Collections.Generic;
using System.ServiceModel;
using ElLib.WCF.Entity;

namespace ElLib.WCF.Service
{
    [ServiceContract]
    public interface IMarketingService
    {
        [OperationContract]
        Marketing GetById(int id);

        [OperationContract]
        IEnumerable<Marketing> GetAll(int id);
    }
}
