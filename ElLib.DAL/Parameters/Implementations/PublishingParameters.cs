using System.Collections.Generic;
using System.Data.SqlClient;
using ElLib.Common.Entity;
using ElLib.DAL.Parameters.Interface;

namespace ElLib.DAL.Parameters.Implementations
{
    public class PublishingParameters : IParameters<Publishing>
    {
        public IEnumerable<SqlParameter> GetParameters(Publishing item)
        {
            return new List<SqlParameter>()
            {
                new SqlParameter("@Id", item.Id),
                new SqlParameter("@Name", item.Name),
                new SqlParameter("@Country", item.Address.Country),
                new SqlParameter("@City", item.Address.City),
                new SqlParameter("@Street", item.Address.Street),
                new SqlParameter("@Home", item.Address.Home)
            };
        }
    }
}
