using System.Collections.Generic;
using ElLib.Common.Entity;

namespace ElLib.BLL.Services.Interfaces
{
    public interface IUserService : IService<User>
    {
        IEnumerable<User> Search(string query);
    }
}
