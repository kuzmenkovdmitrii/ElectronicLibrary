using System.Configuration;
using ElLib.Common.Entity;
using ElLib.DAL.Converter.Interface;
using ElLib.DAL.Repository.Interface;

namespace ElLib.DAL.Repository
{
    public class AddressRepository : CommonRepository<Address>, IAddressRepository
    {
        readonly string connectionString = ConfigurationSettings.AppSettings["ConnectionString"];

        public AddressRepository(IConverter<Address> converter)
        {
            ConnectionString = connectionString;
            EntityName = "Address";
            TableName = "Addresses";
            Converter = converter;
        }
    }
}
