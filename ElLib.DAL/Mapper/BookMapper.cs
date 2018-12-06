using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using ElLib.Common.Entity;
using ElLib.DAL.Mapper.Interface;

namespace ElLib.DAL.Mapper
{
    public class BookMapper : IMapper<Book>
    {
        public IEnumerable<Book> FromTable(DataTable table)
        {
            IEnumerable<Book> list = table.AsEnumerable().Select(a => new Book()
                {
                    Id = (int) a["Id"],
                    Name = (string) a["Name"],
                    Categories = new List<BookCategory>(),
                    Authors = new List<Author>(),
                    PublishingDate = (DateTime) a["PublishingDate"],
                    Language = new Language()
                    {
                        Id = (int) a["LanguageId"],
                        Name = (string) a["LanguageName"]
                    },
                    Publishing = new List<Publishing>(),
                    Picture = (Url) a["Picture"],
                    File = (Url) a["File"]
                }
            ).ToList();

            return list;
        }

        public DataTable ToTable(Book item)
        {
            throw new NotImplementedException();
        }
    }
}
