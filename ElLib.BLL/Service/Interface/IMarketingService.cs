using System.Collections.Generic;
using ElLib.WCF.Entity;

namespace ElLib.BLL.Service.Interface
{
    public interface IMarketingService
    {
        Marketing GetById(int id);

        IEnumerable<Marketing> GetAll(int id);
    }
}
