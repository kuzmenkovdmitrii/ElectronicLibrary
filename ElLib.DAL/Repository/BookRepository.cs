using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using ElLib.Common.Entity;
using ElLib.DAL.Converter.Interface;
using ElLib.DAL.Repository.Interface;
using ElLib.DAL.StoredProcedure;

namespace ElLib.DAL.Repository
{
    public class BookRepository : CommonRepository<Book>, IBookRepository
    {
        readonly string connectionString = ConfigurationSettings.AppSettings["ConnectionString"];

        readonly IBookCategoryRepository bookCategoryRepository;
        readonly IAuthorRepository authorRepository;
        readonly IPublishingRepository publishingRepository;

        public BookRepository(
            IConverter<Book> converter, 
            IBookCategoryRepository bookCategoryRepository,
            IAuthorRepository authorRepository,
            IPublishingRepository publishingRepository, 
            IProcedureExecuter executer)
            : base(executer)
        {
            ConnectionString = connectionString;
            EntityName = "Book";
            TableName = "Books";
            Converter = converter;
            this.authorRepository = authorRepository;
            this.bookCategoryRepository = bookCategoryRepository;
            this.publishingRepository = publishingRepository;
        }

        public override IEnumerable<Book> GetAll()
        {
            return base.GetAll();
        }

        public override Book GetById(int id)
        {
            Book book = base.GetById(id);
            book.Publishing = publishingRepository.GetPublishingsByBookId(book.Id).ToList();
            book.Authors = authorRepository.GetAuthorsByBookId(book.Id).ToList();
            book.Categories = bookCategoryRepository.GetBookCategoriesByBookId(book.Id).ToList();

            return book;
        }

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
