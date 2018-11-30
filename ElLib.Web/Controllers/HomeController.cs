using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElLib.BLL.Service.Interface;
using ElLib.Common.Logger;
using log4net;

namespace ElLib.Web.Controllers
{
    public class HomeController : Controller
    {
        IBookCategoryService service;

        ILog log;

        public HomeController(IBookCategoryService service)
        {
            log = Logger.For(this);
            this.service = service;
        }

        // GET: Home
        public ActionResult Index()
        {
            @ViewBag.Hello = service.GetBook();
            log.Info("Hello logging world!");
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