using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using ElLib.BLL.Services.Interfaces;
using ElLib.BLL.ValidationInfo;
using ElLib.Common.Entities;
using ElLib.Common.Exception;
using ElLib.DAL.Repositories.Interfaces;

namespace ElLib.BLL.Services.Implementations
{
    public class BookService : IBookService
    {
        private readonly IBookRepository bookRepository;
        private readonly IBookCategoryRepository bookCategoryRepository;
        private readonly IAuthorRepository authorRepository;
        private readonly IPublishingRepository publishingRepository;

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
            ThrowException.CheckId(id);

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

            try
            {
                bookRepository.Create(item);
            }
            catch (Exception e)
            {
                return new OperationDetails(false, "Произошла ошибка при создании книги");
            }

            return new OperationDetails(true);
        }

        public OperationDetails Update(Book item)
        {
            ThrowException.CheckNull(item);

            try
            {
                bookRepository.Update(item);
            }
            catch (Exception e)
            {
                return new OperationDetails(false, "Произошла ошибка при обновлении книги");
            }

            return new OperationDetails(true);
        }

        public OperationDetails Delete(int? id)
        {
            ThrowException.CheckId(id);

            try
            {
                bookRepository.Delete(id);
            }
            catch (SqlException e)
            {
                return new OperationDetails(false, "Произошла ошибка при удалении книги");
            }

            return new OperationDetails(true);
        }

        public IEnumerable<Book> Search(string query)
        {
            ThrowException.CheckNull(query);

            IEnumerable<Book> books = bookRepository.GetByQuery(query);

            foreach (var book in books)
            {
                book.Publishings = publishingRepository.GetByBookId(book.Id).ToList();
                book.Authors = authorRepository.GetByBookId(book.Id).ToList();
                book.Categories = bookCategoryRepository.GetByBookId(book.Id).ToList();
            }

            return books;
        }
    }
}
