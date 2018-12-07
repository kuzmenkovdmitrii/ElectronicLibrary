using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public IEnumerable<SqlParameter> AddParameters(Author item)
        {
            return new List<SqlParameter>()
            {
                new SqlParameter("@Id", item.Id),
                new SqlParameter("@Name", item.Name),
                new SqlParameter("@LastName", item.LastName),
                new SqlParameter("@MiddleName", item.MiddleName),
                new SqlParameter("@Email", item.Email)
            };
        }
    }
}