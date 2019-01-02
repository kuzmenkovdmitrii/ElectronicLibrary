using System.Threading.Tasks;
using ElLib.BLL.Infrastructure;
using ElLib.Common.Entity;

namespace ElLib.BLL.Services.Interfaces
{
    public interface IAuthService
    {
        Task<OperationDetails> Register(User user, string password);
        Task<OperationDetails> Authenticate(string login, string password);
        Task<OperationDetails> Logout();
    }
}
