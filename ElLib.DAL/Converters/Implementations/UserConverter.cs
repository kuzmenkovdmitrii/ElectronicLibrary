using System;
using System.Data.SqlClient;
using ElLib.Common.Converter;
using ElLib.Common.Entities;

namespace ElLib.DAL.Converters.Implementations
{
    public class UserConverter : IConverter<User>
    {
        public User FromReader(SqlDataReader reader)
        {
            return new User()
            {
                Id = (int)reader["Id"],
                Email = (string)reader["Email"],
                UserName = (string)reader["UserName"]
            };
        }
    }
}
