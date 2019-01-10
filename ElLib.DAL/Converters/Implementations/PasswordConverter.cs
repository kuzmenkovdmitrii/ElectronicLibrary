using System.Data.SqlClient;
using ElLib.Common.Converter;

namespace ElLib.DAL.Converters.Implementations
{
    public class PasswordConverter : IConverter<string>
    {
        public string FromReader(SqlDataReader reader)
        {
            return reader["Password"].ToString();
        }
    }
}
