using System;
using System.Collections.Generic;
using System.Linq;
using ElLib.BLL.Infrastructure;
using ElLib.BLL.Services.Interfaces;
using ElLib.Common.Entity;
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
            User user = userRepository.GetById(id);
            user.Roles = roleRepository.GetByUserId(user.Id).ToList();

            return user;
        }

        public OperationDetails Create(User item)
        {
            try
            {
                userRepository.Create(item);
                return new OperationDetails(true, "Автор успешно создан");
            }
            catch (Exception e)
            {
                return new OperationDetails(false, "Произошла ошибка при создании автора");
            }
        }

        public OperationDetails Update(User item)
        {
            try
            {
                userRepository.Update(item);
                return new OperationDetails(true, "Автор успешно обновлён");
            }
            catch (Exception e)
            {
                return new OperationDetails(false, "Произошла ошибка при обновлении автора");
            }
        }

        public OperationDetails Delete(int id)
        {
            try
            {
                userRepository.Delete(id);
                return new OperationDetails(true, "Автор успешно удалён");
            }
            catch (Exception e)
            {
                return new OperationDetails(false, "Произошла ошибка при удалении автора");
            }
        }
    }
}
