using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ElLib.Common.Converter;
using ElLib.Common.Entity;
using ElLib.Common.ProcedureExecuter;
using ElLib.DAL.Converters.Implementations;
using ElLib.DAL.Parameters.Interface;
using ElLib.DAL.Repositories.Interfaces;

namespace ElLib.DAL.Repositories.Implementations
{
    public class AuthorRepository : CommonRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(
            IProcedureExecuter executer,
            IParameters<Author> parameters, 
            IConverter<Author> converter)
            : base(executer)
        {
            EntityName = "Author";
            TableName = "Authors";
            Parameters = parameters;
            Converter = converter;
        }

        public IEnumerable<Author> GetAuthorsByBookId(int? id)
        {
            if (id == null)
            {
                throw new ArgumentNullException();
            }

            string storedProcedure = "usp_Select" + TableName + "ByBookId";

            Executer.Parameters.Add(new SqlParameter("@Id", id));

            return Executer.Execute<Author>(storedProcedure, Converter);
        }
    }
}
