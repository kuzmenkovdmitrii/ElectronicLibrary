using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using ElLib.Common.Entity;
using ElLib.DAL.Mapper.Interface;

namespace ElLib.DAL.Mapper
{
    class PublishingMapper : IMapper<Publishing>
    {
        public IEnumerable<Publishing> FromTable(DataTable table)
        {
            IEnumerable<Publishing> list = table.AsEnumerable().Select(a => new Publishing()
                {
                    Id = (int)a["Id"],
                    Name = (string)a["Name"],
                    Address = new Address()
                    {
                        Id = (int)a["AddressId"],
                        Country = (string)a["AddressCountry"],
                        City = (string)a["AddressCity"],
                        Street = (string)a["AddressStreet"],
                        Home = (string)a["AddressHome"],
                    }
                }
            ).ToList();

            return list;
        }

        public DataTable ToTable(Publishing item)
        {
            throw new NotImplementedException();
        }
    }
}
