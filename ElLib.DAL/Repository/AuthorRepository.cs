using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using ElLib.Common.Entity;
using ElLib.DAL.Converter.Interface;
using ElLib.DAL.Repository.Interface;
using ElLib.DAL.StoredProcedure;

namespace ElLib.DAL.Repository
{
    public class AuthorRepository : CommonRepository<Author>, IAuthorRepository
    {
        readonly string connectionString = ConfigurationSettings.AppSettings["ConnectionString"];

        public AuthorRepository(IConverter<Author> converter, IProcedureExecuter executer)
            : base(executer)
        {
            ConnectionString = connectionString;
            EntityName = "Author";
            TableName = "Authors";
            Converter = converter;
        }

        public IEnumerable<Author> GetAuthorsByBookId(int id)
        {
            string storedProcedure = "usp_SelectAuthorsByBookId";

            Executer.Parameters.Add(new SqlParameter("@Id", id));

            return Converter.FromTable(Executer.Execute(storedProcedure));
        }
    }
}
