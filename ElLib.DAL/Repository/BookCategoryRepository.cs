using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using ElLib.Common.Entity;
using ElLib.DAL.Converter.Interface;
using ElLib.DAL.Repository.Interface;

namespace ElLib.DAL.Repository
{
    public class BookCategoryRepository : CommonRepository<BookCategory>, IBookCategoryRepository
    {
        readonly string connectionString = ConfigurationSettings.AppSettings["ConnectionString"];

        public BookCategoryRepository(IConverter<BookCategory> converter)
        {
            ConnectionString = connectionString;
            EntityName = "BookCategory";
            TableName = "BookCategories";
            Converter = converter;
        }

        public IEnumerable<BookCategory> GetBookCategoriesByBookId(int id)
        {
            string storedProcedure = "usp_SelectBookCategoriesByBookId";

            IEnumerable<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@Id", id)
            };

            return Converter.FromTable(Execute(storedProcedure,parameters));
        }
    }
}
