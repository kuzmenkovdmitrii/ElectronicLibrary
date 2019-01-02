using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Security;
using ElLib.BLL.Infrastructure;
using ElLib.BLL.Services.Interfaces;
using ElLib.Common.Entity;
using ElLib.DAL.Repositories.Interfaces;

namespace ElLib.BLL.Services.Implementations
{
    public class AuthService : IAuthService
    {
        readonly IUserRepository userRepository;

        public AuthService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<OperationDetails> Register(User user, string password)
        {
            List<User> users = userRepository.GetAll().ToList();

            if (users.FirstOrDefault(x => x.UserName == user.UserName) != null)
            {
                return new OperationDetails(false, "Пользователь с таким логином уже существует");
            }

            if (users.FirstOrDefault(x => x.Email == user.Email) != null)
            {
                return new OperationDetails(false, "Пользователь с таким Email уже существует");
            }

            userRepository.Create(user, password);

            return new OperationDetails(true, "Пользователь успешно зарегистрирован");
        }

        public async Task<OperationDetails> Authenticate(string login, string password)
        {
            if (string.IsNullOrEmpty(login))
            {
                return new OperationDetails(false, "Неверный логин");
            }

            if (string.IsNullOrEmpty(password))
            {
                return new OperationDetails(false, "Неверный пароль");
            }

            User user = userRepository.GetByUserName(login);

            if (user == null)
            {
                return new OperationDetails(false, "Пользователь с таким логином не найден");
            }

            if (!CheckPassword(user, password))
            {
                return new OperationDetails(false, "Неверный пароль");
            }

            JavaScriptSerializer serializer = new JavaScriptSerializer();

            string userData = serializer.Serialize(user);

            FormsAuthenticationTicket authTicket = new FormsAuthenticationTicket(
                1,
                user.UserName,
                DateTime.Now,
                DateTime.Now.AddMinutes(15),
                false,
                userData);

            string encTicket = FormsAuthentication.Encrypt(authTicket);

            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encTicket);

            HttpContext.Current.Response.Cookies.Add(cookie);

            return new OperationDetails(true, "Пользователь успешно авторизирован");
        }

        public async Task<OperationDetails> Logout()
        {
            FormsAuthentication.SignOut();

            return new OperationDetails(true, "Пользователь успешно вышел");
        }

        private bool CheckPassword(User user, string password)
        {
            string pass = userRepository.GetPassword(user.Id);
            if (userRepository.GetPassword(user.Id) != password)
            {
                return false;
            }

            return true;
        }
    }
}
