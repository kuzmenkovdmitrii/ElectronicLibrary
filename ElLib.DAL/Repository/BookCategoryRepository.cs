using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using ElLib.Common.Entity;
using ElLib.DAL.Converter.Interface;
using ElLib.DAL.Parameters.Interface;
using ElLib.DAL.Repository.Interface;
using ElLib.DAL.StoredProcedure;

namespace ElLib.DAL.Repository
{
    public class BookCategoryRepository : CommonRepository<BookCategory>, IBookCategoryRepository
    {
        public BookCategoryRepository(IParameters<BookCategory> parameters, IConverter<BookCategory> converter, IProcedureExecuter executer)
            : base(executer)
        {
            EntityName = "BookCategory";
            TableName = "BookCategories";
            Parameters = parameters;
            Converter = converter;
        }

        public IEnumerable<BookCategory> GetBookCategoriesByBookId(int id)
        {
            string storedProcedure = "usp_Select" + TableName + "ByBookId";

            Executer.Parameters.Add(new SqlParameter("@Id", id));

            return Converter.FromTable(Executer.Execute(storedProcedure));
        }
    }
}
