using System.Collections.Generic;
using ElLib.Common.Entity;

namespace ElLib.DAL.Repositories.Interfaces
{
    public interface IAuthorRepository : IRepository<Author>
    {
        IEnumerable<Author> GetAuthorsByBookId(int? id);
    }
}
