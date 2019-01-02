using System.Collections.Generic;
using System.Data;
using System.Linq;
using ElLib.Common.Entity;
using ElLib.DAL.Converters.Interface;

namespace ElLib.DAL.Converters.Implementations
{
    class LanguageConverter : IConverter<Language>
    {
        public IEnumerable<Language> FromTable(DataTable table)
        {
            return table.AsEnumerable().Select(a => new Language()
            {
                Id = (int) a["Id"],
                Name = (string) a["Name"],
            }).ToList();
        }

        public IEnumerable<Language> ToTable(Language item)
        {
            throw new System.NotImplementedException();
        }
    }
}