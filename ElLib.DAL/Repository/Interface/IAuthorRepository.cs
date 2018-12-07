using System.Collections.Generic;
using ElLib.Common.Entity;

namespace ElLib.DAL.Repository.Interface
{
    public interface IAuthorRepository : IRepository<Author>
    {
        IEnumerable<Author> GetAuthorsByBookId(int id);
    }
}
