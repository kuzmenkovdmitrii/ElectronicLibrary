using System.Collections.Generic;
using System.Data.SqlClient;
using ElLib.Common.Entity;
using ElLib.DAL.Parameters.Interface;

namespace ElLib.DAL.Parameters.Implementations
{
    public class RoleParameters : IParameters<Role>
    {
        public IEnumerable<SqlParameter> GetParameters(Role item)
        {
            return new List<SqlParameter>()
            {
                new SqlParameter("@Id", item.Id),
                new SqlParameter("@Name", item.Name),
                new SqlParameter("@Description", item.Description),
            };
        }
    }
}
