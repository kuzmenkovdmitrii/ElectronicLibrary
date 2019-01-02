using System.Collections.Generic;
using ElLib.Common.Entity;

namespace ElLib.BLL.Services.Interfaces
{
    public interface IPublishingService : IService<Publishing>
    {
        IEnumerable<Publishing> GetByBookId(int id);
    }
}
