using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using ElLib.Common.Entity;
using ElLib.DAL.Converter.Interface;

namespace ElLib.DAL.Converter
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

        public IEnumerable<SqlParameter> AddParameters(Language item)
        {
            return new List<SqlParameter>()
            {
                new SqlParameter("@Id", item.Id),
                new SqlParameter("@Name", item.Name)
            };
        }
    }
}