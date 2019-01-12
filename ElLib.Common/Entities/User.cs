using System.Collections.Generic;

namespace ElLib.Common.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public ICollection<Role> Roles { get; set; }
    }
}