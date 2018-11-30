using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElLib.Web.Controllers
{
    public class AdminPageController : Controller
    {
        // GET: AdminPage
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Author()
        {
            return RedirectToAction("All", "Author");
        }

        public ActionResult BookCategory()
        {
            return RedirectToAction("All", "BookCategory");
        }

        public ActionResult Language()
        {
            return RedirectToAction("All", "Language");
        }

        public ActionResult Publishing()
        {
            return RedirectToAction("All", "Publishing");
        }
    }
}