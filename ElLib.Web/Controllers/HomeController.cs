using System.Web.Mvc;
using ElLib.BLL.Service.Interface;
using ElLib.Common.Logger;
using log4net;

namespace ElLib.Web.Controllers
{
    public class HomeController : Controller
    {
        IBookCategoryService service;

        //ILog log;

        public HomeController(IBookCategoryService service)
        {
            //log = Logger.For(this);
            this.service = service;
        }

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