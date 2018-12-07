using System.Collections.Generic;
using ElLib.Common.Entity;

namespace ElLib.BLL.Service.Interface
{
    public interface IPublishingService
    {
        IEnumerable<Publishing> GetAll();
        IEnumerable<Publishing> GetByBookId(int id);
        Publishing GetById(int id);

    }
}
