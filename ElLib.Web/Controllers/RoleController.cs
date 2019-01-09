using System.Linq;
using System.Web.Mvc;
using ElLib.BLL.Services.Interfaces;
using ElLib.Common.Entity;

namespace ElLib.Web.Controllers
{
    public class RoleController : Controller
    {
        readonly IRoleService roleService;
        readonly IUserService userService;

        public RoleController(IRoleService roleService, IUserService userService)
        {
            this.roleService = roleService;
            this.userService = userService;
        }

        public ActionResult AddRoleToUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddRoleToUser(int? user, int? role)
        {
            if (user != null && role != null)
            {
                User foundUser = userService.GetById(user);
                Role foundRole = roleService.GetById(role);

                roleService.AddRoleToUser(foundUser, foundRole);

            }

            return null; //TODO redirect to 401
        }

        public ActionResult AllRolesForSelect()
        {
            return PartialView(roleService.GetAll().Where(x=>x.Name != "User"));
        }
    }
}