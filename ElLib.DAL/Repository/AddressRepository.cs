using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using ElLib.Common.Entity;
using ElLib.DAL.Mapper;
using ElLib.DAL.Mapper.Interface;
using ElLib.DAL.Repository.Interface;

namespace ElLib.DAL.Repository
{
    public class AddressRepository : CommonRepository<Address>, IAddressRepository
    {
        readonly string connectionString = ConfigurationSettings.AppSettings["ConnectionString"];

        public AddressRepository(IMapper<Address> mapper)
        {
            ConnectionString = connectionString;
            TableName = "Addresses";
            Mapper = mapper;
        }
    }
}
