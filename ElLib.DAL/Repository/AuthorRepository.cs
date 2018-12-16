using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using ElLib.Common.Entity;
using ElLib.DAL.Converter.Interface;
using ElLib.DAL.Parameters.Interface;
using ElLib.DAL.Repository.Interface;
using ElLib.DAL.StoredProcedure;

namespace ElLib.DAL.Repository
{
    public class AuthorRepository : CommonRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(IParameters<Author> parameters, IConverter<Author> converter, IProcedureExecuter executer)
            : base(executer)
        {
            EntityName = "Author";
            TableName = "Authors";
            Parameters = parameters;
            Converter = converter;
        }

        public IEnumerable<Author> GetAuthorsByBookId(int id)
        {
            string storedProcedure = "usp_Select" + TableName + "ByBookId";

            Executer.Parameters.Add(new SqlParameter("@Id", id));

            return Converter.FromTable(Executer.Execute(storedProcedure));
        }
    }
}
