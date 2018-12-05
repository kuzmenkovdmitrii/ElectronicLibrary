using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ElLib.Common.Entity;
using ElLib.DAL.Repository.Interface;

namespace ElLib.DAL.Repository
{
    public class BookRepository : CommonRepository, IBookRepository
    {
        public IEnumerable<Book> GetAll()
        {
            throw new NotImplementedException();
        }

        public Book GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Create(Book item)
        {
            throw new NotImplementedException();
        }

        public void Update(Book item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
