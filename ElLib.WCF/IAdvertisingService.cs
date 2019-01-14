using System.Collections.Generic;
using System.ServiceModel;
using ElLib.Common.Entities.WCF;

namespace ElLib.WCF
{
    [ServiceContract]
    public interface IAdvertisingService
    {
        [OperationContract]
        IEnumerable<Advertising> GetRandomByCount(int count);
    }
}
