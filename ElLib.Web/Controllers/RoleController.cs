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
            User foundUser = userService.GetById(user);
            Role foundRole = roleService.GetById(role);

            roleService.AddRoleToUser(foundUser, foundRole);
            //TODO
            //if (result.Successed)
            //{
            //    return RedirectToAction("All");
            //}

            //ModelState.AddModelError(result.Property, result.Message);
            return null;
        }

        public ActionResult AllRolesForSelect()
        {
            return PartialView(roleService.GetAll().Where(x => x.Name != "User"));
        }
    }
}