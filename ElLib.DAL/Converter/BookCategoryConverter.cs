using System.Collections.Generic;
using System.Data;
using System.Linq;
using ElLib.Common.Entity;
using ElLib.DAL.Converter.Interface;

namespace ElLib.DAL.Converter
{
    class BookCategoryConverter : IConverter<BookCategory>
    {
        public IEnumerable<BookCategory> FromTable(DataTable table)
        {
            return table.AsEnumerable().Select(a => new BookCategory()
                {
                    Id = (int) a["Id"],
                    Name = (string) a["Name"],
                }).ToList();
        }

        public IEnumerable<BookCategory> ToTable(BookCategory item)
        {
            throw new System.NotImplementedException();
        }
    }
}