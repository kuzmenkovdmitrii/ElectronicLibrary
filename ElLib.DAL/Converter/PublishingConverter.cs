using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using ElLib.Common.Entity;
using ElLib.DAL.Converter.Interface;

namespace ElLib.DAL.Converter
{
    class PublishingConverter : IConverter<Publishing>
    {
        public IEnumerable<Publishing> FromTable(DataTable table)
        {
            return table.AsEnumerable().Select(a => new Publishing()
            {
                Id = (int) a["Id"],
                Name = (string) a["Name"],
                Address = new Address()
                {
                    Id = (int) a["AddressId"],
                    Country = (string) a["AddressCountry"],
                    City = (string) a["AddressCity"],
                    Street = (string) a["AddressStreet"],
                    Home = (string) a["AddressHome"],
                }
            }).ToList();
        }

        public IEnumerable<SqlParameter> AddParameters(Publishing item)
        {
            return new List<SqlParameter>()
            {
                new SqlParameter("@Id", item.Id),
                new SqlParameter("@Name", item.Name),
                new SqlParameter("@AddressId", item.Address.Id)
            };
        }
    }
}