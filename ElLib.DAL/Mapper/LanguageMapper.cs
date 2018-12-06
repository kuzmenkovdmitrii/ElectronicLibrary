using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElLib.Common.Entity;
using ElLib.DAL.Mapper.Interface;

namespace ElLib.DAL.Mapper
{
    class LanguageMapper : IMapper<Language>
    {

        public IEnumerable<Language> FromTable(DataTable table)
        {
            IEnumerable<Language> list = table.AsEnumerable().Select(a => new Language()
                {
                    Id = (int) a["Id"],
                    Name = (string) a["Name"],
                }
            ).ToList();

            return list;
        }

        public DataTable ToTable(Language item)
        {
            throw new NotImplementedException();
        }
    }
}
