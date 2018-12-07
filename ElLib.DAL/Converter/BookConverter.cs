using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using ElLib.Common.Entity;
using ElLib.DAL.Converter.Interface;

namespace ElLib.DAL.Converter
{
    public class BookConverter : IConverter<Book>
    {
        public IEnumerable<Book> FromTable(DataTable table)
        {
            return table.AsEnumerable().Select(a => new Book()
            {
                Id = (int) a["Id"],
                Name = (string) a["Name"],
                PublishingDate = (DateTime) a["PublishingDate"],
                Language = new Language()
                {
                    Id = (int) a["LanguageId"],
                    Name = (string) a["LanguageName"]
                },
                Picture = new Url((string) a["Picture"]),
                File = new Url((string) a["File"])
            }).ToList();
        }

        public IEnumerable<SqlParameter> AddParameters(Book item)
        {
            return new List<SqlParameter>()
            {
                new SqlParameter("@Id", item.Id),
                new SqlParameter("@Name", item.Name),
                new SqlParameter("@PublishingDate", item.PublishingDate),
                new SqlParameter("@LanguageId", item.Language.Id),
                new SqlParameter("@Picture", item.Picture),
                new SqlParameter("@File", item.File)
            };
        }
    }
}