using System.Threading.Tasks;
using ElLib.BLL.Infrastructure;
using ElLib.Common.Entities;

namespace ElLib.BLL.Services.Interfaces
{
    public interface IAuthService
    {
        Task<OperationDetails> Register(User user, string password);
        Task<OperationDetails> Authenticate(string login, string password);
        Task<OperationDetails> Logout();

        OperationDetails Update(User item);
        OperationDetails UpdatePassword(User user, string oldPassword, string newPassword);
    }
}
