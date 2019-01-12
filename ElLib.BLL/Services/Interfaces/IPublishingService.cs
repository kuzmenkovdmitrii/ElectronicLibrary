using System.Collections.Generic;
using ElLib.Common.Entities;

namespace ElLib.BLL.Services.Interfaces
{
    public interface IPublishingService : IService<Publishing>
    {
        IEnumerable<Publishing> Search(string query);
        bool CheckName(string name);
    }
}
