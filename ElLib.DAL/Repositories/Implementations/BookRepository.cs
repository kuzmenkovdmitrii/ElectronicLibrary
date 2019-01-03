using System;
using System.Collections.Generic;
using ElLib.Common.Entity;
using ElLib.Common.ProcedureExecuter;
using ElLib.DAL.Converters.Interface;
using ElLib.DAL.Parameters.Interface;
using ElLib.DAL.Repositories.Interfaces;

namespace ElLib.DAL.Repositories.Implementations
{
    public class BookRepository : CommonRepository<Book>, IBookRepository
    {
        readonly IBookCategoryRepository bookCategoryRepository;
        readonly IAuthorRepository authorRepository;
        readonly IPublishingRepository publishingRepository;

        public BookRepository(
            IProcedureExecuter executer,
            IParameters<Book> parameters,
            IConverter<Book> converter)
            : base(executer)
        {
            EntityName = "Book";
            TableName = "Books";
            Parameters = parameters;
            Converter = converter;
        }

        public override Book GetById(int? id)
        {
            if (id == null)
            {
                throw new ArgumentNullException();
            }

            Book book = base.GetById(id);
            

            return book;
        }

        public IEnumerable<Book> GetByAuthorId(int? id)
        {
            if (id == null)
            {
                throw new ArgumentNullException();
            }

            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetByBookCategoryId(int? id)
        {
            if (id == null)
            {
                throw new ArgumentNullException();
            }

            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetByLanguageId(int? id)
        {
            if (id == null)
            {
                throw new ArgumentNullException();
            }

            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetByPublishingId(int? id)
        {
            if (id == null)
            {
                throw new ArgumentNullException();
            }

            throw new NotImplementedException();
        }
    }
}
