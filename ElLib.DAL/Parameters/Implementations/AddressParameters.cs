using System.Collections.Generic;
using System.Data.SqlClient;
using ElLib.Common.Entity;
using ElLib.DAL.Parameters.Interface;

namespace ElLib.DAL.Parameters.Implementations
{
    public class AddressParameters : IParameters<Address>
    {
        public IEnumerable<SqlParameter> GetParameters(Address item)
        {
            return new List<SqlParameter>()
            {
                new SqlParameter("@Id", item.Id),
                new SqlParameter("@Country", item.Country),
                new SqlParameter("@City", item.City),
                new SqlParameter("@Street", item.Street),
                new SqlParameter("@Home", item.Home)
            };
        }
    }
}
