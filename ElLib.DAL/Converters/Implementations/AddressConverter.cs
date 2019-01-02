using System.Collections.Generic;
using System.Data;
using System.Linq;
using ElLib.Common.Entity;
using ElLib.DAL.Converters.Interface;

namespace ElLib.DAL.Converters.Implementations
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

        public IEnumerable<Address> ToTable(Address item)
        {
            throw new System.NotImplementedException();
        }
    }
}
