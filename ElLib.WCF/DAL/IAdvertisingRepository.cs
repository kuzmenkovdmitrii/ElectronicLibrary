using System.Collections.Generic;
using ElLib.Common.Entities.WCF;

namespace ElLib.WCF.DAL
{
    public interface IAdvertisingRepository
    {
        IEnumerable<Advertising> GetRandomByCount(int count);
    }
}