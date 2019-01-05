using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using ElLib.Common.Converter;
using ElLib.Common.Entity;
using ElLib.Common.ProcedureExecuter;
using ElLib.DAL.Converters.Implementations;
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

        public override void Create(Book item)
        {
            string storedProcedure = "usp_Create" + EntityName;

            Executer.Parameters = Parameters.GetParameters(item).Where(x => x.ParameterName != "@Id").ToList();

            Book createdBook = Executer.Execute<Book>(storedProcedure, Converter).FirstOrDefault();

            foreach (var author in item.Authors)
            {
                AddAuthor(createdBook, author);
            }

            foreach (var publishing in item.Publishings)
            {
                AddPublishing(createdBook, publishing);
            }

            foreach (var category in item.Categories)
            {
                AddCategory(createdBook, category);
            }
        }

        public void AddAuthor(Book book, Author author)
        {
            if (book == null || author == null)
            {
                throw new ArgumentNullException();
            }

            string storedProcedure = "usp_AddAuthorToBook";

            Executer.Parameters.Add(new SqlParameter("@BookId", book.Id));
            Executer.Parameters.Add(new SqlParameter("@AuthorId", author.Id));

            Executer.ExecuteVoid(storedProcedure);
        }

        public void AddPublishing(Book book, Publishing publishing)
        {
            if (book == null || publishing == null)
            {
                throw new ArgumentNullException();
            }

            string storedProcedure = "usp_AddPublishingToBook";

            Executer.Parameters.Add(new SqlParameter("@BookId", book.Id));
            Executer.Parameters.Add(new SqlParameter("@PublishingId", publishing.Id));

            Executer.ExecuteVoid(storedProcedure);
        }

        public void AddCategory(Book book, BookCategory category)
        {
            if (book == null || category == null)
            {
                throw new ArgumentNullException();
            }

            string storedProcedure = "usp_AddBookCategoryToBook";

            Executer.Parameters.Add(new SqlParameter("@BookId", book.Id));
            Executer.Parameters.Add(new SqlParameter("@BookCategoryId", category.Id));

            Executer.ExecuteVoid(storedProcedure);
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
