using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using ElLib.Common.Entity;
using ElLib.DAL.Converter.Interface;

namespace ElLib.DAL.Converter
{
    class AddressConverter : IConverter<Address>
    {
        public IEnumerable<Address> FromTable(DataTable table)
        {
            return table.AsEnumerable().Select(a => new Address()
                {
                    Id = (int) a["Id"],
                    Country = (string) a["Country"],
                    City = (string) a["City"],
                    Street = (string) a["Street"],
                    Home = (string) a["Home"]
                }).ToList();
        }

        public IEnumerable<SqlParameter> AddParameters(Address item)
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
