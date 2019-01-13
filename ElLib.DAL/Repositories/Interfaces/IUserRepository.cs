using System.Collections.Generic;
using ElLib.Common.Entities;

namespace ElLib.DAL.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        IEnumerable<User> GetByRoleId(int? id);
        void Create(User item, string password);
        string GetPassword(int? id);
        void UpdatePassword(User user, string password);
        User GetByUserName(string userName);
        User GetByEmail(string email);
        IEnumerable<User> GetByQuery(string query);
    }
}
