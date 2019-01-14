using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using ElLib.BLL.Infrastructure;
using ElLib.BLL.Services.Interfaces;
using ElLib.Common.Entities;
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

        public IEnumerable<User> GetByRoleId(int? id)
        {
            return userRepository.GetByRoleId(id);
        }

        public User GetById(int? id)
        {
            ThrowException.CheckId(id);

            User user = userRepository.GetById(id);
            user.Roles = roleRepository.GetByUserId(user.Id).ToList();

            return user;
        }

        public IEnumerable<User> Search(string query)
        {
            ThrowException.CheckNull(query);

            return userRepository.GetByQuery(query);
        }

        public bool CheckUserName(string username)
        {
            ThrowException.CheckNull(username);

            User user = userRepository.GetByUserName(username);

            return user == null;
        }

        public bool CheckEmail(string email)
        {
            ThrowException.CheckNull(email);

            User user = userRepository.GetByEmail(email);

            return user == null;
        }
    }
}
