using System.Collections.Generic;
using System.Data.SqlClient;
using ElLib.Common.Entity;
using ElLib.DAL.Parameters.Interface;

namespace ElLib.DAL.Parameters
{
    public class AuthorParameters : IParameters<Author>
    {
        public IEnumerable<SqlParameter> GetParameters(Author item)
        {
            return new List<SqlParameter>()
            {
                new SqlParameter("@Id", item.Id),
                new SqlParameter("@Name", item.Name),
                new SqlParameter("@LastName", item.LastName),
                new SqlParameter("@MiddleName", item.MiddleName),
                new SqlParameter("@Email", item.Email)
            };
        }
    }
}
