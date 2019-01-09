using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ElLib.Common.Converter;
using ElLib.Common.Entity;
using ElLib.Common.ProcedureExecuter;
using ElLib.DAL.Parameters.Interface;
using ElLib.DAL.Repositories.Interfaces;

namespace ElLib.DAL.Repositories.Implementations
{
    public class BookCategoryRepository : CommonRepository<BookCategory>, IBookCategoryRepository
    {
        public BookCategoryRepository(
            IProcedureExecuter executer, 
            IConverter<BookCategory> converter,
            IParameters<BookCategory> parameters)
            : base(executer)
        {
            EntityName = "BookCategory";
            TableName = "BookCategories";
            Parameters = parameters;
            Converter = converter;
        }

        public IEnumerable<BookCategory> GetBookCategoriesByBookId(int? id)
        {
            if (id == null)
            {
                throw new ArgumentNullException();
            }

            string storedProcedure = "usp_Select" + TableName + "ByBookId";

            Executer.Parameters.Add(new SqlParameter("@Id", id));

            return Executer.Execute<BookCategory>(storedProcedure, Converter);
        }
    }
}
