using System.Collections.Generic;
using System.Data.SqlClient;
using ElLib.Common.Entity;
using ElLib.Common.ProcedureExecuter;
using ElLib.DAL.Converters.Interface;
using ElLib.DAL.Parameters.Interface;
using ElLib.DAL.Repositories.Interfaces;

namespace ElLib.DAL.Repositories.Implementations
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
