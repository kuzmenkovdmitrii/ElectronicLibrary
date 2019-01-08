using System.Collections.Generic;
using System.Web.Configuration;
using ElLib.BLL.Services.Interfaces;
using ElLib.Common.Entity;
using ElLib.DAL.Repositories.Interfaces;

namespace ElLib.BLL.Services.Implementations
{
    public class RoleService : IRoleService
    {
        readonly IRoleRepository roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            this.roleRepository = roleRepository;
        }

        public IEnumerable<Role> GetAll()
        {
            return roleRepository.GetAll();
        }

        public Role GetById(int? id)
        {
            return roleRepository.GetById(id);
        }

        public void AddRoleToUser(User user, Role role)
        {
            roleRepository.AddRoleToUser(user,role);
        }
    }
}
