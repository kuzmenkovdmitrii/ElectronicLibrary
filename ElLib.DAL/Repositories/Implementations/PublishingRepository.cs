using System.Collections.Generic;
using System.Data.SqlClient;
using ElLib.Common.Entity;
using ElLib.Common.ProcedureExecuter;
using ElLib.DAL.Converters.Interface;
using ElLib.DAL.Parameters.Interface;
using ElLib.DAL.Repositories.Interfaces;

namespace ElLib.DAL.Repositories.Implementations
{
    public class PublishingRepository : CommonRepository<Publishing>, IPublishingRepository
    {
        public PublishingRepository(IParameters<Publishing> parameters, IConverter<Publishing> converter, IProcedureExecuter executer)
            : base(executer)
        {
            EntityName = "Publishing";
            TableName = "Publishings";
            Parameters = parameters;
            Converter = converter;
        }

        public IEnumerable<Publishing> GetPublishingsByBookId(int id)
        {
            string storedProcedure = "usp_Select" + TableName + "ByBookId";

            Executer.Parameters.Add(new SqlParameter("@Id", id));

            return Converter.FromTable(Executer.Execute(storedProcedure));
        }
    }
}