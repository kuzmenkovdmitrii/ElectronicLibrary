using System.Collections.Generic;
using ElLib.Common.Entity;

namespace ElLib.BLL.Service.Interface
{
    public interface IPublishingService
    {
        IEnumerable<Publishing> GetAll();
        Publishing GetById(int id);
    }
}
