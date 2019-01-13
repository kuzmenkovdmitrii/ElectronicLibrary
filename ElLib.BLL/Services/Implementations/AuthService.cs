using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Security;
using ElLib.BLL.Infrastructure;
using ElLib.BLL.Services.Interfaces;
using ElLib.Common.Entities;
using ElLib.Common.Exception;
using ElLib.DAL.Repositories.Interfaces;

namespace ElLib.BLL.Services.Implementations
{
    public class AuthService : IAuthService
    {
        readonly IUserRepository userRepository;
        readonly IRoleRepository roleRepository;

        public AuthService(IUserRepository userRepository, IRoleRepository roleRepository)
        {
            this.userRepository = userRepository;
            this.roleRepository = roleRepository;
        }

        public async Task<OperationDetails> Register(User user, string password)
        {
            if (userRepository.GetByUserName(user.UserName) != null)
            {
                return new OperationDetails(false, "Пользователь с таким логином уже существует", "UserName");
            }

            if (userRepository.GetByUserName(user.Email) != null)
            {
                return new OperationDetails(false, "Пользователь с таким Email уже существует", "Email");
            }

            userRepository.Create(user, password);

            User createdUser = userRepository.GetByUserName(user.UserName);

            if (createdUser == null)
            {
                return new OperationDetails(false, "Не удалось создать пользователя");
            }

            Role defaultRole = roleRepository.GetByName("User");

            roleRepository.AddRoleToUser(createdUser, defaultRole);

            return new OperationDetails(true);
        }

        public async Task<OperationDetails> Authenticate(string login, string password)
        {
            if (string.IsNullOrEmpty(login))
            {
                return new OperationDetails(false, "Логин не может быть пустым", "UserName");
            }

            if (string.IsNullOrEmpty(password))
            {
                return new OperationDetails(false, "Пароль не может быть пустым", "Password");
            }

            User user = userRepository.GetByUserName(login);

            if (user == null)
            {
                return new OperationDetails(false, "Пользователь с таким логином не найден", "UserName");
            }

            if (!CheckPassword(user, password))
            {
                return new OperationDetails(false, "Неверный пароль", "Password");
            }

            user.Roles = roleRepository.GetByUserId(user.Id).ToList();

            CreateCookie(user);

            return new OperationDetails(true);
        }

        public async Task<OperationDetails> Logout()
        {
            FormsAuthentication.SignOut();

            return new OperationDetails(true, "Пользователь успешно вышел");
        }

        private void CreateCookie(User user)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            string userData = serializer.Serialize(user);

            FormsAuthenticationTicket authTicket = new FormsAuthenticationTicket(
                1,
                user.UserName,
                DateTime.Now,
                DateTime.Now.AddMinutes(15),
                true,
                userData);

            string encTicket = FormsAuthentication.Encrypt(authTicket);

            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encTicket);

            HttpContext.Current.Response.Cookies.Add(cookie);
        }

        private void UpdateCookie(User user)
        {
            //TODO
        }

        private bool CheckPassword(User user, string password)
        {
            ThrowException.CheckNull(user);
            ThrowException.CheckNull(password);

            if (userRepository.GetPassword(user.Id) != password)
            {
                return false;
            }

            return true;
        }
    }
}
