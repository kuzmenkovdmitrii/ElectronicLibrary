using System.Collections.Generic;
using System.ServiceModel;
using ElLib.Common.Entities.WCF;

namespace ElLib.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAdvertisingService" in both code and config file together.
    [ServiceContract]
    public interface IAdvertisingService
    {
        [OperationContract]
        IEnumerable<Advertising> GetRandomByCount(int? count = 6);
    }
}
