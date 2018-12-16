using System.Collections.Generic;
using ElLib.Common.Entity;

namespace ElLib.BLL.Service.Interface
{
    public interface IPublishingService : IService<Publishing>
    {
        IEnumerable<Publishing> GetByBookId(int id);
    }
}
