﻿using System.Collections.Generic;
using ElLib.Common.Entity;

namespace ElLib.DAL.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        void Create(User item, string password);
        string GetPassword(int? id);
        User GetByUserName(string userName);
        IEnumerable<User> GetByQuery(string query);
    }
}
