using System.Web.Mvc;

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
            return RedirectToAction("Index", "Admin");
        }
    }
}