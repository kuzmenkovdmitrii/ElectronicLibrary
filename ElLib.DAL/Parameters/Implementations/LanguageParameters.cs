using System.Collections.Generic;
using System.Data.SqlClient;
using ElLib.Common.Entities;
using ElLib.DAL.Parameters.Interface;

namespace ElLib.DAL.Parameters.Implementations
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
    }
}
