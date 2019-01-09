using System;
using System.Collections.Generic;
using System.Linq;
using ElLib.BLL.Infrastructure;
using ElLib.BLL.Services.Interfaces;
using ElLib.Common.Entity;
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
                book.Publishings = publishingRepository.GetPublishingsByBookId(book.Id).ToList();
                book.Authors = authorRepository.GetAuthorsByBookId(book.Id).ToList();
                book.Categories = bookCategoryRepository.GetBookCategoriesByBookId(book.Id).ToList();
            }

            return books;
        }

        public Book GetById(int? id)
        {
            Book book = bookRepository.GetById(id);
            book.Publishings = publishingRepository.GetPublishingsByBookId(id).ToList();
            book.Authors = authorRepository.GetAuthorsByBookId(id).ToList();
            book.Categories = bookCategoryRepository.GetBookCategoriesByBookId(id).ToList();
            return book;
        }

        public OperationDetails Create(Book item)
        {
            try
            {
                item.PublishingDate = DateTime.Now;
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

        public OperationDetails Delete(int? id)
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
