using System.Web.Mvc;

namespace ElLib.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("All", "Book");
        }
    }
}