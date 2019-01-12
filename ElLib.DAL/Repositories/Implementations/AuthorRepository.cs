﻿using System.Collections.Generic;
using System.Data.SqlClient;
using ElLib.Common.Converter;
using ElLib.Common.Entities;
using ElLib.Common.ProcedureExecuter;
using ElLib.DAL.Parameters.Interface;
using ElLib.DAL.Repositories.Interfaces;
using ElLib.Common.Exception;

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

        public IEnumerable<Author> GetByBookId(int? id)
        {
            ThrowException.CheckId(id);

            string storedProcedure = "usp_Select" + TableName + "ByBookId";

            Executer.Parameters.Add(new SqlParameter("@Id", id));

            return Executer.Execute(storedProcedure, Converter);
        }

        public IEnumerable<Author> GetByQuery(string query)
        {
            ThrowException.CheckNull(query);

            string storedProcedure = "usp_Select" + TableName + "ByQuery";

            Executer.Parameters.Add(new SqlParameter("@Query", query));

            return Executer.Execute(storedProcedure, Converter);
        }
    }
}
