using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using ElLib.Common.Entity;
using ElLib.DAL.Converter.Interface;
using ElLib.DAL.Repository.Interface;

namespace ElLib.DAL.Repository
{
    public class AuthorRepository : CommonRepository<Author>, IAuthorRepository
    {
        readonly string connectionString = ConfigurationSettings.AppSettings["ConnectionString"];

        public AuthorRepository(IConverter<Author> converter)
        {
            ConnectionString = connectionString;
            EntityName = "Author";
            TableName = "Authors";
            Converter = converter;
        }

        public IEnumerable<Author> GetAuthorsByBookId(int id)
        {
            string storedProcedure = "usp_SelectAuthorsByBookId";

            IEnumerable<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@Id", id)
            };

            return Converter.FromTable(Execute(storedProcedure,parameters));
        }
    }
}
