using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using ElLib.Common.Entity;
using ElLib.DAL.Converters.Interface;

namespace ElLib.DAL.Converters.Implementations
{
    public class UserConverter : IConverter<User>
    {
        public IEnumerable<User> FromTable(DataTable table)
        {
            return table.AsEnumerable().Select(a => new User()
            {
                Id = (int)a["Id"],
                Email = (string)a["Email"],
                UserName = (string)a["UserName"]
            }).ToList();
        }

        public IEnumerable<User> ToTable(User item)
        {
            throw new NotImplementedException();
        }
    }
}
