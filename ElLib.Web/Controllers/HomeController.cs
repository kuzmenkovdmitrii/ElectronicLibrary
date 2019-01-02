using System.Web.Mvc;
using ElLib.BLL.Services.Interfaces;

namespace ElLib.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registration()
        {
            return RedirectToAction("Registration", "Auth");
        }

        public ActionResult Login()
        {
            return RedirectToAction("Login", "Auth");
        }

        public ActionResult AdminPage()
        {
            return RedirectToAction("Index", "AdminPage");
        }
    }
}