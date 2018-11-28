using System.Collections.Generic;
using System.Web.Mvc;
using ElLib.Common.Entity;

namespace ElLib.Web.Models
{
    public class UserModel
    {
        [HiddenInput(DisplayValue = false)]
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public ICollection<Role> Roles { get; set; }
    }
}