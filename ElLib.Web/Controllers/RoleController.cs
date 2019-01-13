using System.Linq;
using System.Web.Mvc;
using ElLib.BLL.Services.Interfaces;
using ElLib.Common.Entities;

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

        [Authorize(Roles = "Admin")]
        public ActionResult AddRoleToUser()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult AddRoleToUser(int? user, int? role)
        {
            if (user == null)
            {
                ModelState.AddModelError("User", "Необходимо выбрать пользователя");
                return View();
            }
            if (role == null)
            {
                ModelState.AddModelError("Role", "Необходимо выбрать роль");
                return View();
            }

            User foundUser = userService.GetById(user);
            Role foundRole = roleService.GetById(role);

            var result = roleService.AddRoleToUser(foundUser, foundRole);

            if (result.Successed)
            {
                return View();
            }

            ModelState.AddModelError(result.Property, result.Message);

            return View();
        }

        public ActionResult AllRolesForSelect()
        {
            return PartialView(roleService.GetAll().Where(x => x.Name != "User"));
        }
    }
}