using System.Collections.Generic;
using ElLib.Common.Entity;

namespace ElLib.DAL.Repositories.Interfaces
{
    public interface IBookCategoryRepository : IRepository<BookCategory>
    {
        IEnumerable<BookCategory> GetBookCategoriesByBookId(int? id);
    }
}
