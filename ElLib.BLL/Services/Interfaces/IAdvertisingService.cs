using System.Collections.Generic;
using ElLib.Common.Entities.WCF;

namespace ElLib.BLL.Services.Interfaces
{
    public interface IAdvertisingService
    {
        IEnumerable<Advertising> GetRandomByCount(int count);
    }
}
