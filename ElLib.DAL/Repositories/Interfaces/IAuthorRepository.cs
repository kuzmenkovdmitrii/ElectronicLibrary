using System.Collections.Generic;
using ElLib.Common.Entities;

namespace ElLib.DAL.Repositories.Interfaces
{
    public interface IAuthorRepository : IRepository<Author>
    {
        IEnumerable<Author> GetByBookId(int? id);
        IEnumerable<Author> GetByQuery(string query);
    }
}
