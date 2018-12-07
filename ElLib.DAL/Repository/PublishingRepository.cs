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
    public class PublishingRepository : CommonRepository<Publishing>, IPublishingRepository
    {
        public string connectionString = ConfigurationSettings.AppSettings["ConnectionString"];

        public PublishingRepository(IConverter<Publishing> converter)
        {
            ConnectionString = connectionString;
            EntityName = "Publishing";
            TableName = "Publishings";
            Converter = converter;
        }

        public IEnumerable<Publishing> GetPublishingsByBookId(int id)
        {
            string storedProcedure = "usp_SelectPublishingsByBookId";

            IEnumerable<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@Id", id)
            };

            return Converter.FromTable(Execute(storedProcedure, parameters));
        }
    }
}