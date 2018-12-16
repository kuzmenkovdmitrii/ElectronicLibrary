using System.Collections.Generic;
using System.Data;
using System.Linq;
using ElLib.Common.Entity;
using ElLib.DAL.Converter.Interface;

namespace ElLib.DAL.Converter
{
    public class AuthorConverter : IConverter<Author>
    {
        public IEnumerable<Author> FromTable(DataTable table)
        {
            return table.AsEnumerable().Select(a => new Author()
                {
                    Id = (int) a["Id"],
                    Name = (string) a["Name"],
                    LastName = (string) a["LastName"],
                    MiddleName = (string) a["MiddleName"],
                    Email = (string) a["Email"]
                }).ToList();
        }

        public IEnumerable<Author> ToTable(Author item)
        {
            throw new System.NotImplementedException();
        }
    }
}