using System.Web.Mvc;
using ElLib.BLL.Services.Interfaces;

namespace ElLib.Web.Controllers
{
    public class UserController : Controller
    {
        readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        public ActionResult All()
        {
            return View();
        }

        [Authorize]
        public ActionResult Info(int? id)
        {
            return View(userService.GetById(id));
        }

        [Authorize]
        public ActionResult Search(string query)
        {
            if (query == null)
            {
                query = "";
            }

            return PartialView(userService.Search(query));
        }

        public ActionResult AllUsersForSelect()
        {
            return PartialView(userService.GetAll());
        }

        public ActionResult AllUsersByRoleIdForSelect(int? id)
        {
            return PartialView(userService.GetByRoleId(id));
        }
    }
}