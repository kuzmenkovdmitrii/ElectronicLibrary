using System.Collections.Generic;
using System.Data.SqlClient;
using ElLib.Common.Entity;
using ElLib.DAL.Parameters.Interface;

namespace ElLib.DAL.Parameters.Implementations
{
    public class UserParameters : IParameters<User>
    {
        public IEnumerable<SqlParameter> GetParameters(User item)
        {
            return new List<SqlParameter>()
            {
                new SqlParameter("@Id", item.Id),
                new SqlParameter("@Email", item.Email),
                new SqlParameter("@UserName", item.UserName),
            };
        }
    }
}
