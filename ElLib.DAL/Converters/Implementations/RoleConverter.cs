using System.Collections.Generic;
using System.Data;
using System.Linq;
using ElLib.Common.Entity;
using ElLib.DAL.Converters.Interface;

namespace ElLib.DAL.Converters.Implementations
{
    public class RoleConverter : IConverter<Role>
    {
        public IEnumerable<Role> FromTable(DataTable table)
        {
            return table.AsEnumerable().Select(a => new Role()
            {
                Id = (int)a["Id"],
                Name = (string)a["Name"],
                Description = (string)a["Description"]
            }).ToList();
        }

        public IEnumerable<Role> ToTable(Role item)
        {
            throw new System.NotImplementedException();
        }
    }
}
