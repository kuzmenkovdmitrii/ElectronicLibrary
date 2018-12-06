using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using ElLib.Common.Entity;
using ElLib.DAL.Mapper;
using ElLib.DAL.Mapper.Interface;
using ElLib.DAL.Repository.Interface;

namespace ElLib.DAL.Repository
{
    public class PublishingRepository : CommonRepository<Publishing>, IPublishingRepository
    {
        public string connectionString = ConfigurationSettings.AppSettings["ConnectionString"];

        public PublishingRepository(IMapper<Publishing> mapper)
        {
            ConnectionString = connectionString;
            TableName = "Publishing";
            Mapper = mapper;
        }
    }
}