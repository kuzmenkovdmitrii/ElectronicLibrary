using System.Collections.Generic;
using ElLib.Common.Entities;

namespace ElLib.DAL.Repositories.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        IEnumerable<Book> GetByQuery(string query);
    }
}
