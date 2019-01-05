using System.Data.SqlClient;
using ElLib.Common.Converter;
using ElLib.Common.Entity;

namespace ElLib.DAL.Converters.Implementations
{
    class PublishingConverter : IConverter<Publishing>
    {
        public Publishing FromReader(SqlDataReader reader)
        {
            return new Publishing()
            {
                Id = (int)reader["Id"],
                Name = (string)reader["Name"],
                Address = new Address()
                {
                    Id = (int)reader["AddressId"],
                    Country = (string)reader["AddressCountry"],
                    City = (string)reader["AddressCity"],
                    Street = (string)reader["AddressStreet"],
                    Home = (string)reader["AddressHome"],
                }
            };
        }
    }
}