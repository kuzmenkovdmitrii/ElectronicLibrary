using System.Web.Mvc;
using ElLib.BLL.Services.Interfaces;

namespace ElLib.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [Authorize(Roles = "Admin")]
        public ActionResult All()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Info(int? id)
        {
            return View(userService.GetById(id));
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Search(string query)
        {
            if (query == null)
            {
                query = "";
            }

            return PartialView(userService.Search(query));
        }

        [Authorize(Roles = "Admin")]
        public ActionResult AllUsersForSelect()
        {
            return PartialView(userService.GetAll());
        }

        [Authorize(Roles = "Admin")]
        public ActionResult AllUsersByRoleIdForSelect(int? id)
        {
            return PartialView(userService.GetByRoleId(id));
        }
    }
}