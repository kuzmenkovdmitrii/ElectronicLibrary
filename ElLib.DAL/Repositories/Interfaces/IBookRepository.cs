using System.Collections.Generic;
using ElLib.Common.Entity;

namespace ElLib.DAL.Repositories.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        IEnumerable<Book> GetByAuthorId(int? id);
        IEnumerable<Book> GetByBookCategoryId(int? id);
        IEnumerable<Book> GetByLanguageId(int? id);
        IEnumerable<Book> GetByPublishingId(int? id);
    }
}
