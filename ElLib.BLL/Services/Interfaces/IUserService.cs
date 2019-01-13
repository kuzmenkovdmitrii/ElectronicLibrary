using System.Collections.Generic;
using ElLib.BLL.Infrastructure;
using ElLib.Common.Entities;

namespace ElLib.BLL.Services.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        IEnumerable<User> GetByRoleId(int? id);
        User GetById(int? id);
        OperationDetails Update(User item);
        OperationDetails UpdatePassword(User user, string oldPassword, string newPassword);

        IEnumerable<User> Search(string query);
        bool CheckUserName(string username);
        bool CheckEmail(string username);
    }
}
