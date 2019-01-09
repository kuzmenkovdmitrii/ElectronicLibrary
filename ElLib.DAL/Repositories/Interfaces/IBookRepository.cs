using System.Collections.Generic;
using ElLib.Common.Entity;

namespace ElLib.DAL.Repositories.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        void AddAuthor(Book book, Author author);
        void AddPublishing(Book book, Publishing publishing);
        void AddCategory(Book book, BookCategory category);

        void RemoveAuthor(Book book, Author author);
        void RemovePublishing(Book book, Publishing publishing);
        void RemoveCategory(Book book, BookCategory category);
    }
}
