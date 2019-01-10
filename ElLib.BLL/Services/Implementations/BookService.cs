using System;
using System.Collections.Generic;
using System.Linq;
using ElLib.BLL.Infrastructure;
using ElLib.BLL.Services.Interfaces;
using ElLib.Common.Entity;
using ElLib.Common.Exception;
using ElLib.DAL.Repositories.Interfaces;

namespace ElLib.BLL.Services.Implementations
{
    public class BookService : IBookService
    {
        readonly IBookRepository bookRepository;
        readonly IBookCategoryRepository bookCategoryRepository;
        readonly IAuthorRepository authorRepository;
        readonly IPublishingRepository publishingRepository;

        public BookService(
            IBookRepository bookRepository,
            IBookCategoryRepository bookCategoryRepository,
            IAuthorRepository authorRepository,
            IPublishingRepository publishingRepository)
        {
            this.bookRepository = bookRepository;
            this.bookCategoryRepository = bookCategoryRepository;
            this.authorRepository = authorRepository;
            this.publishingRepository = publishingRepository;
        }

        public IEnumerable<Book> GetAll()
        {
            IEnumerable<Book> books = bookRepository.GetAll();

            foreach (var book in books)
            {
                book.Publishings = publishingRepository.GetByBookId(book.Id).ToList();
                book.Authors = authorRepository.GetByBookId(book.Id).ToList();
                book.Categories = bookCategoryRepository.GetByBookId(book.Id).ToList();
            }

            return books;
        }

        public Book GetById(int? id)
        {
            ThrowException.CheckNull(id);

            Book book = bookRepository.GetById(id);
            book.Publishings = publishingRepository.GetByBookId(id).ToList();
            book.Authors = authorRepository.GetByBookId(id).ToList();
            book.Categories = bookCategoryRepository.GetByBookId(id).ToList();

            return book;
        }

        public OperationDetails Create(Book item)
        {
            ThrowException.CheckNull(item);

            item.PublishingDate = DateTime.Now;

            bookRepository.Create(item);

            return new OperationDetails(true, "Книга успешно создана");
        }

        public OperationDetails Update(Book item)
        {
            ThrowException.CheckNull(item);

            bookRepository.Update(item);

            return new OperationDetails(true, "Книга успешно обновлена");
        }

        public OperationDetails Delete(int? id)
        {
            ThrowException.CheckNull(id);

            bookRepository.Delete(id);

            return new OperationDetails(true, "Книга успешно удалена");
        }
    }
}
