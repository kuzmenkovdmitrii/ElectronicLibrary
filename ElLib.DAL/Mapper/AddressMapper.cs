using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using ElLib.Common.Entity;
using ElLib.DAL.Mapper.Interface;

namespace ElLib.DAL.Mapper
{
    class AddressMapper : IMapper<Address>
    {
        public IEnumerable<Address> FromTable(DataTable table)
        {
            IEnumerable<Address> list = table.AsEnumerable().Select(a => new Address()
                {
                    Id = (int) a["Id"],
                    Country = (string) a["Country"],
                    City = (string) a["City"],
                    Street = (string) a["Street"],
                    Home = (string) a["Home"]
                }
            ).ToList();

            return list;
        }

        public DataTable ToTable(Address item)
        {
            throw new NotImplementedException();
        }
    }
}
