using System.Collections.Generic;
using ElLib.BLL.Service.Interface;
using ElLib.Common.Entity;
using ElLib.DAL.Repository.Interface;

namespace ElLib.BLL.Service
{
    public class BookService : IBookService
    {
        IBookRepository bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public IEnumerable<Book> GetAll()
        {
            return bookRepository.GetAll();
        }

        public Book GetById(int id)
        {
            return bookRepository.GetById(id);
        }

        public void Create(Book item)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Book item)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
