using System.Data.SqlClient;
using ElLib.Common.Converter;
using ElLib.Common.Entity;

namespace ElLib.DAL.Converters.Implementations
{
    class AddressConverter : IConverter<Address>
    {
        public Address FromReader(SqlDataReader reader)
        {
            return new Address()
            {
                Id = (int)reader["Id"],
                Country = (string)reader["Country"],
                City = (string)reader["City"],
                Street = (string)reader["Street"],
                Home = (string)reader["Home"]
            };
        }
    }
}
