using System.Collections.Generic;
using System.Linq;
using ElLib.BLL.Infrastructure;
using ElLib.BLL.Services.Interfaces;
using ElLib.Common.Entity;
using ElLib.Common.Exception;
using ElLib.DAL.Repositories.Interfaces;

namespace ElLib.BLL.Services.Implementations
{
    public class UserService : IUserService
    {
        readonly IUserRepository userRepository;
        readonly IRoleRepository roleRepository;

        public UserService(IUserRepository userRepository, IRoleRepository roleRepository)
        {
            this.userRepository = userRepository;
            this.roleRepository = roleRepository;
        }

        public IEnumerable<User> GetAll()
        {
            return userRepository.GetAll();
        }

        public User GetById(int? id)
        {
            ThrowException.CheckNull(id);

            User user = userRepository.GetById(id);
            user.Roles = roleRepository.GetByUserId(user.Id).ToList();

            return user;
        }

        public OperationDetails Create(User item)
        {
            ThrowException.CheckNull(item);

            userRepository.Create(item);

            return new OperationDetails(true, "Автор успешно создан");
        }

        public OperationDetails Update(User item)
        {
            ThrowException.CheckNull(item);

            userRepository.Update(item);

            return new OperationDetails(true, "Автор успешно обновлён");
        }

        public OperationDetails Delete(int? id)
        {
            ThrowException.CheckNull(id);

            userRepository.Delete(id);

            return new OperationDetails(true, "Автор успешно удалён");
        }

        public IEnumerable<User> Search(string query)
        {
            return userRepository.GetByQuery(query);
        }
    }
}
