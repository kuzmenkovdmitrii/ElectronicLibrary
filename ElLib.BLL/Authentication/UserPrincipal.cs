using System.Linq;
using System.Security.Principal;
using ElLib.Common.Entity;

namespace ElLib.BLL.Authentication
{
    public class UserPrincipal : IPrincipal
    {
        public IIdentity Identity { get; }
        public User User { get; }

        public UserPrincipal(User user)
        {
            User = user;
            Identity = new GenericIdentity(user.Email);
        }

        public bool IsInRole(string role)
        {
            if (User.Roles.FirstOrDefault(x=>x.Name == role) != null)
            {
                return true;
            }

            return false;
        }
    }
}
