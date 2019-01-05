using System.Data.SqlClient;
using ElLib.Common.Converter;
using ElLib.Common.Entity;

namespace ElLib.DAL.Converters.Implementations
{
    public class RoleConverter : IConverter<Role>
    {
        public Role FromReader(SqlDataReader reader)
        {
            return new Role()
            {
                Id = (int)reader["Id"],
                Name = (string)reader["Name"],
                Description = (string)reader["Description"]
            };
        }
    }
}
