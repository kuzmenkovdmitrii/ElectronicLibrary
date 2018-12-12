using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using ElLib.Common.Entity;
using ElLib.DAL.Converter.Interface;
using ElLib.DAL.Repository.Interface;
using ElLib.DAL.StoredProcedure;

namespace ElLib.DAL.Repository
{
    public class PublishingRepository : CommonRepository<Publishing>, IPublishingRepository
    {
        public string connectionString = ConfigurationSettings.AppSettings["ConnectionString"];

        public PublishingRepository(IConverter<Publishing> converter, IProcedureExecuter executer)
            : base(executer)
        {
            ConnectionString = connectionString;
            EntityName = "Publishing";
            TableName = "Publishings";
            Converter = converter;
        }

        public IEnumerable<Publishing> GetPublishingsByBookId(int id)
        {
            string storedProcedure = "usp_SelectPublishingsByBookId";

            Executer.Parameters.Add(new SqlParameter("@Id", id));

            return Converter.FromTable(Executer.Execute(storedProcedure));
        }
    }
}