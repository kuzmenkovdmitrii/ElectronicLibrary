using System;
using System.Collections.Generic;
using System.Linq;
using ElLib.Common.Entity;
using ElLib.Common.ProcedureExecuter;
using ElLib.DAL.Converter.Interface;
using ElLib.DAL.Parameters.Interface;
using ElLib.DAL.Repository.Interface;

namespace ElLib.DAL.Repository
{
    public class BookRepository : CommonRepository<Book>, IBookRepository
    {
        readonly IBookCategoryRepository bookCategoryRepository;
        readonly IAuthorRepository authorRepository;
        readonly IPublishingRepository publishingRepository;

        public BookRepository(
            IParameters<Book> parameters,
            IConverter<Book> converter, 
            IBookCategoryRepository bookCategoryRepository,
            IAuthorRepository authorRepository,
            IPublishingRepository publishingRepository, 
            IProcedureExecuter executer)
            : base(executer)
        {
            EntityName = "Book";
            TableName = "Books";
            Parameters = parameters;
            Converter = converter;
            this.authorRepository = authorRepository;
            this.bookCategoryRepository = bookCategoryRepository;
            this.publishingRepository = publishingRepository;
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
