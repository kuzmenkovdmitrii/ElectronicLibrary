using System.Collections.Generic;
using ElLib.Common.Entities;

namespace ElLib.BLL.Services.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        IEnumerable<User> GetByRoleId(int? id);
        User GetById(int? id);

        IEnumerable<User> Search(string query);
        bool CheckUserName(string username);
        bool CheckEmail(string username);
    }
}
