using System.Collections.Generic;
using ElLib.Common.Entities;

namespace ElLib.DAL.Repositories.Interfaces
{
    public interface IPublishingRepository : IRepository<Publishing>
    {
        IEnumerable<Publishing> GetByBookId(int? id);
        IEnumerable<Publishing> GetByQuery(string query);
        Publishing GetByName(string name);
    }
}
