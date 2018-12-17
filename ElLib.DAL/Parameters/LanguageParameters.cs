using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ElLib.Common.Entity;
using ElLib.DAL.Parameters.Interface;

namespace ElLib.DAL.Parameters
{
    public class LanguageParameters : IParameters<Language>
    {
        public IEnumerable<SqlParameter> GetParameters(Language item)
        {
            return new List<SqlParameter>()
            {
                new SqlParameter("@Id", item.Id),
                new SqlParameter("@Name", item.Name)
            };
        }

        public IEnumerable<SqlParameter> GetParameters()
        {
            return new List<SqlParameter>()
            {
                new SqlParameter("@Id", SqlDbType.Int),
                new SqlParameter("@Name", SqlDbType.NVarChar)
            };
        }
    }
}
