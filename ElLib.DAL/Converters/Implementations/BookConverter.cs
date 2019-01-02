using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using ElLib.Common.Entity;
using ElLib.DAL.Converters.Interface;

namespace ElLib.DAL.Converters.Implementations
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

        public IEnumerable<Book> ToTable(Book item)
        {
            throw new NotImplementedException();
        }
    }
}