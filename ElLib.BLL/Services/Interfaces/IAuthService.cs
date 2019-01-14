using ElLib.BLL.Infrastructure;
using ElLib.Common.Entities;

namespace ElLib.BLL.Services.Interfaces
{
    public interface IAuthService
    {
        OperationDetails Register(User user, string password);
        OperationDetails Authenticate(string login, string password);
        OperationDetails Logout();

        OperationDetails Update(User item);
        OperationDetails UpdatePassword(User user, string oldPassword, string newPassword);
    }
}
