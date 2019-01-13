using System.Collections.Generic;
using ElLib.BLL.Infrastructure;
using ElLib.Common.Entities;

namespace ElLib.BLL.Services.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        User GetById(int? id);
        OperationDetails Update(User item);
        IEnumerable<User> Search(string query);
        bool CheckUserName(string username);
        bool CheckEmail(string username);
        OperationDetails UpdatePassword(User user, string oldPassword, string newPassword);
    }
}
