using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using ElLib.Common.Entity;

namespace ElLib.BLL.Authentication
{
    public class UserPrincipal : IPrincipal
    {
        public IIdentity Identity { get; }
        public int Id { get; }
        public string Email { get; }
        public string UserName { get; }

        public string Role
        {
            get
            {
                int min = Roles.Min(x => x.Id);
                return Roles.First(x=>x.Id == min).Name;
            }
        }
        private ICollection<Role> Roles { get; }

        public UserPrincipal()
        {
            Roles = new List<Role>();
            Identity = new GenericIdentity("");
        }

        public UserPrincipal(User user)
        {
            Id = user.Id;
            Email = user.Email;
            UserName = user.UserName;
            Roles = user.Roles;
            Identity = new GenericIdentity(user.UserName);
        }

        public bool IsInRole(string role)
        {
            if (Roles.FirstOrDefault(x=>x.Name == role) != null)
            {
                return true;
            }

            return false;
        }
    }
}
