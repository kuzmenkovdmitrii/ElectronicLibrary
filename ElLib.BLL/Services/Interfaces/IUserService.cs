using System.Collections.Generic;
using ElLib.BLL.Infrastructure;
using ElLib.Common.Entities;

namespace ElLib.BLL.Services.Interfaces
{
    public interface IUserService : IService<User>
    {
        IEnumerable<User> Search(string query);
        bool CheckUserName(string username);
        bool CheckEmail(string username);
        OperationDetails UpdatePassword(User user, string oldPassword, string newPassword);
    }
}
