using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using ElLib.Common.Converter;
using ElLib.Common.Entity;
using ElLib.Common.Exception;
using ElLib.Common.ProcedureExecuter;
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
            ThrowException.CheckNull(id);

            Book book = base.GetById(id);

            return book;
        }

        public override void Create(Book item)
        {
            ThrowException.CheckNull(item);

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

        public override void Update(Book item)
        {
            ThrowException.CheckNull(item);

            {
                string storedProcedure = "usp_Update" + EntityName;

                Executer.Parameters = Parameters.GetParameters(item).Where(x => x.ParameterName != "@PublishingDate").ToList();

                Executer.ExecuteVoid(storedProcedure);

            }

            {
                string storedProcedure = "usp_DeleteBookReferences";

                Executer.Parameters.Add(new SqlParameter("@Id", item.Id));

                Executer.ExecuteVoid(storedProcedure);
            }

            foreach (var author in item.Authors)
            {
                AddAuthor(item, author);
            }

            foreach (var publishing in item.Publishings)
            {
                AddPublishing(item, publishing);
            }

            foreach (var category in item.Categories)
            {
                AddCategory(item, category);
            }
        }

        public IEnumerable<Book> GetByQuery(string query)
        {
            ThrowException.CheckNull(query);

            string storedProcedure = "usp_Select" + TableName + "ByQuery";

            Executer.Parameters.Add(new SqlParameter("@Query", query));

            return Executer.Execute<Book>(storedProcedure, Converter);
        }

        public void AddAuthor(Book book, Author author)
        {
            ThrowException.CheckNull(book);
            ThrowException.CheckNull(author);

            string storedProcedure = "usp_AddAuthorToBook";

            Executer.Parameters.Add(new SqlParameter("@BookId", book.Id));
            Executer.Parameters.Add(new SqlParameter("@AuthorId", author.Id));

            Executer.ExecuteVoid(storedProcedure);
        }

        public void AddPublishing(Book book, Publishing publishing)
        {
            ThrowException.CheckNull(book);
            ThrowException.CheckNull(publishing);

            string storedProcedure = "usp_AddPublishingToBook";

            Executer.Parameters.Add(new SqlParameter("@BookId", book.Id));
            Executer.Parameters.Add(new SqlParameter("@PublishingId", publishing.Id));

            Executer.ExecuteVoid(storedProcedure);
        }

        public void AddCategory(Book book, BookCategory category)
        {
            ThrowException.CheckNull(book);
            ThrowException.CheckNull(category);

            string storedProcedure = "usp_AddBookCategoryToBook";

            Executer.Parameters.Add(new SqlParameter("@BookId", book.Id));
            Executer.Parameters.Add(new SqlParameter("@BookCategoryId", category.Id));

            Executer.ExecuteVoid(storedProcedure);
        }
    }
}