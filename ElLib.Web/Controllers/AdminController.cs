using System.Web.Mvc;

namespace ElLib.Web.Controllers
{
    public class AdminController : Controller
    {
        [Authorize(Roles = "Admin, Editor")]
        public ActionResult Index()
        {
            return View();
        }
    }
}