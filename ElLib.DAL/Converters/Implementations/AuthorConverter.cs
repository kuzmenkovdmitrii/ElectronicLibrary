using System.Data.SqlClient;
using ElLib.Common.Converter;
using ElLib.Common.Entity;

namespace ElLib.DAL.Converters.Implementations
{
    public class AuthorConverter : IConverter<Author>
    {
        public Author FromReader(SqlDataReader reader)
        {
            return new Author()
            {
                Id = (int)reader["Id"],
                Name = (string)reader["Name"],
                LastName = (string)reader["LastName"],
                MiddleName = (string)reader["MiddleName"],
                Email = (string)reader["Email"]
            };
        }
    }
}