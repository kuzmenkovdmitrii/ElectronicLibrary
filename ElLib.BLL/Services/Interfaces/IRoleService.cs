﻿using System.Collections.Generic;
using ElLib.Common.Entity;

namespace ElLib.BLL.Services.Interfaces
{
    public interface IRoleService
    {
        IEnumerable<Role> GetAll();
        Role GetById(int? id);
        void AddRoleToUser(User user, Role role);
    }
}
