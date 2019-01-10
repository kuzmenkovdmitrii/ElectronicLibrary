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

        public IEnumerable<BookCategory> GetByBookId(int? id)
        {
            ThrowException.CheckNull(id);

            string storedProcedure = "usp_Select" + TableName + "ByBookId";

            Executer.Parameters.Add(new SqlParameter("@Id", id));

            return Executer.Execute(storedProcedure, Converter);
        }

        public IEnumerable<BookCategory> GetByQuery(string query)
        {
            ThrowException.CheckNull(query);

            string storedProcedure = "usp_Select" + TableName + "ByQuery";

            Executer.Parameters.Add(new SqlParameter("@Query", query));

            return Executer.Execute(storedProcedure, Converter);
        }

        public BookCategory GetByName(string name)
        {
            ThrowException.CheckNull(name);

            string storedProcedure = "usp_Select" + EntityName + "ByName";

            Executer.Parameters.Add(new SqlParameter("@Name", name));

            return Executer.Execute(storedProcedure, Converter).FirstOrDefault();
        }
    }
}
