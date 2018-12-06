using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using ElLib.Common.Entity;
using ElLib.DAL.Mapper.Interface;

namespace ElLib.DAL.Mapper
{
    public class AuthorMapper : IMapper<Author>
    {
        public IEnumerable<Author> FromTable(DataTable table)
        {
            IEnumerable<Author> list = table.AsEnumerable().Select(a => new Author()
                {
                    Id = (int)a["Id"],
                    Name = (string)a["Name"],
                    LastName = (string)a["LastName"],
                    MiddleName = (string)a["MiddleName"],
                    Email = (string)a["Email"]
                }
            ).ToList();

            return list;
        }

        public DataTable ToTable(Author item)
        {
            throw new NotImplementedException();
        }
    }
}
