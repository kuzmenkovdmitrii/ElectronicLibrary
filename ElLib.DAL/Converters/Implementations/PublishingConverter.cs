using System.Collections.Generic;
using System.Data;
using System.Linq;
using ElLib.Common.Entity;
using ElLib.DAL.Converters.Interface;

namespace ElLib.DAL.Converters.Implementations
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

        public IEnumerable<Publishing> ToTable(Publishing item)
        {
            throw new System.NotImplementedException();
        }
    }
}