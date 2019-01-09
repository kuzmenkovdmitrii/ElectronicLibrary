using System.Linq;
using System.Web.Mvc;
using System.Web.WebPages;
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

        public ActionResult Info(int? id)
        {
            return View(userService.GetById(id));
        }

        public ActionResult Search(string query)
        {
            if (query.IsEmpty())
            {
                query = "";
            }

            return PartialView(userService.GetAll().Where(
                x => x.UserName.Contains(query) ||
                     x.Email.Contains(query)).ToList());
        }

        public ActionResult AllUsersForSelect()
        {
            return PartialView(userService.GetAll());
        }
    }
}