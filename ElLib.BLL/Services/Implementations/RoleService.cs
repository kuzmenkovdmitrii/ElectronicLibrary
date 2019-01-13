using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using ElLib.BLL.Infrastructure;
using ElLib.BLL.Services.Interfaces;
using ElLib.Common.Entities;
using ElLib.Common.Exception;
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
            ThrowException.CheckId(id);

            return roleRepository.GetById(id);
        }

        public OperationDetails AddRoleToUser(User user, Role role)
        {
            ThrowException.CheckNull(user);
            ThrowException.CheckNull(role);

            if (!CheckRole(user, role.Name))
            {
                return new OperationDetails(false, "У пользователя уже есть эта роль");
            }

            try
            {
                if (role.Name == "Admin" && CheckRole(user, "Editor"))
                {
                    Role editorRole = roleRepository.GetByName("Editor");
                    roleRepository.AddRoleToUser(user, editorRole);
                }

                roleRepository.AddRoleToUser(user, role);
            }
            catch (SqlException)
            {
                return new OperationDetails(false, "Не удалось добавить роль пользователю");
            }

            return new OperationDetails(true);
        }

        private bool CheckRole(User user, string role)
        {
            if (roleRepository.GetByUserId(user.Id).FirstOrDefault(x => x.Name == role) != null)
            {
                return false;
            }

            return true;
        }
    }
}
