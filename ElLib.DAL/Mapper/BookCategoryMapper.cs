using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using ElLib.Common.Entity;
using ElLib.DAL.Mapper.Interface;

namespace ElLib.DAL.Mapper
{
    class BookCategoryMapper : IMapper<BookCategory>
    {
        public IEnumerable<BookCategory> FromTable(DataTable table)
        {
            IEnumerable<BookCategory> list = table.AsEnumerable().Select(a => new BookCategory()
                {
                    Id = (int)a["Id"],
                    Name = (string)a["Name"],
                }
            ).ToList();

            return list;
        }

        public DataTable ToTable(BookCategory item)
        {
            throw new NotImplementedException();
        }
    }
}
