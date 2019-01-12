using System.Collections.Generic;
using ElLib.Common.Entities;

namespace ElLib.DAL.Repositories.Interfaces
{
    public interface IRoleRepository : IRepository<Role>
    {
        IEnumerable<Role> GetByUserId(int? id);
        Role GetByName(string name);
        void AddRoleToUser(User user, Role role);
    }
}
