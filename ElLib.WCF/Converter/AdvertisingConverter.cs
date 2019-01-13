using System.Data.SqlClient;
using System.Security.Policy;
using ElLib.Common.Converter;
using ElLib.Common.Entities.WCF;

namespace ElLib.WCF.Converter
{
    public class AdvertisingConverter : IConverter<Advertising>
    {
        public Advertising FromReader(SqlDataReader reader)
        {
            return new Advertising()
            {
                Id = (int)reader["Id"],
                Title = (string)reader["Title"],
                Url = new Url((string)reader["Url"]),
                Picture = new Url((string)reader["Picture"])
            };
        }
    }
}