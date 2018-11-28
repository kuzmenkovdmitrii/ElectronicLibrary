using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElLib.BLL.Service.Interface;

namespace ElLib.Web.Controllers
{
    public class HomeController : Controller
    {
        IBookCategoryService service;

        public HomeController(IBookCategoryService service)
        {
            this.service = service;
        }

        // GET: Home
        public ActionResult Index()
        {
            @ViewBag.Hello = service.GetBook();
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
    }
}