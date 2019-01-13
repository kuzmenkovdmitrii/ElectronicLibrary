using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

            try
            {
                roleRepository.AddRoleToUser(user, role);
            }
            catch (SqlException)
            {
                return new OperationDetails(true, "Не удалось добавить роль пользователю");
            }

            return new OperationDetails(true);
        }
    }
}
