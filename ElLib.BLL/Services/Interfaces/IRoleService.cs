using System.Collections.Generic;
using ElLib.BLL.Infrastructure;
using ElLib.Common.Entities;

namespace ElLib.BLL.Services.Interfaces
{
    public interface IRoleService
    {
        IEnumerable<Role> GetAll();
        Role GetById(int? id);
        OperationDetails AddRoleToUser(User user, Role role);
    }
}
