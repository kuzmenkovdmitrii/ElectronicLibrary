using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ElLib.Common.Converter;
using ElLib.Common.Entity;
using ElLib.Common.Exception;
using ElLib.Common.ProcedureExecuter;
using ElLib.DAL.Parameters.Interface;
using ElLib.DAL.Repositories.Interfaces;

namespace ElLib.DAL.Repositories.Implementations
{
    public class PublishingRepository : CommonRepository<Publishing>, IPublishingRepository
    {
        public PublishingRepository(
            IProcedureExecuter executer,
            IParameters<Publishing> parameters,
            IConverter<Publishing> converter)
            : base(executer)
        {
            EntityName = "Publishing";
            TableName = "Publishings";
            Parameters = parameters;
            Converter = converter;
        }

        public IEnumerable<Publishing> GetPublishingsByBookId(int? id)
        {
            ThrowException.CheckNull(id);

            string storedProcedure = "usp_Select" + TableName + "ByBookId";

            Executer.Parameters.Add(new SqlParameter("@Id", id));

            return Executer.Execute<Publishing>(storedProcedure, Converter);
        }
    }
}