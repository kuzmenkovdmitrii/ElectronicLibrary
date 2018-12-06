using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ElLib.Common.Entity;
using ElLib.DAL.Repository.Interface;

namespace ElLib.DAL.Repository
{
    public class BookRepository : CommonRepository<Book>, IBookRepository
    {
        public IEnumerable<Book> GetByAuthorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetByBookCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetByLanguageId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetByPublishingId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
