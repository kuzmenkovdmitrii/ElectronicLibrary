using System;
using System.Collections.Generic;
using ElLib.BLL.Infrastructure;
using ElLib.BLL.Services.Interfaces;
using ElLib.Common.Entity;
using ElLib.DAL.Repositories.Interfaces;

namespace ElLib.BLL.Services.Implementations
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

        public OperationDetails Create(Book item)
        {
            try
            {
                bookRepository.Create(item);
                return new OperationDetails(true, "Книга успешно создана");
            }
            catch (Exception e)
            {
                return new OperationDetails(false, "Произошла ошибка при создании книги");
            }
        }

        public OperationDetails Update(Book item)
        {
            try
            {
                bookRepository.Update(item);
                return new OperationDetails(true, "Книга успешно обновлена");
            }
            catch (Exception e)
            {
                return new OperationDetails(false, "Произошла ошибка при обновлении книги");
            }
        }

        public OperationDetails Delete(int id)
        {
            try
            {
                bookRepository.Delete(id);
                return new OperationDetails(true, "Книга успешно удалена");
            }
            catch (Exception e)
            {
                return new OperationDetails(false, "Произошла ошибка при удалении книги");
            }
        }
    }
}
