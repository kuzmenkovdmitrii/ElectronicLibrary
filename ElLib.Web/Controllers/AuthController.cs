using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElLib.Web.Controllers
{
    public class AuthController : Controller
    {
        //IUserService UserService { get; }

        //private IAuthenticationManager AuthenticationManager
        //{
        //    get { return HttpContext.GetOwinContext().Authentication; }
        //}

        //public AccountController(IUserService userService)
        //{
        //    UserService = userService;
        //}

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Registration()
        {
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> Registration(RegisterModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var user = Mapper.Map<RegisterModel, User>(model);

        //        var result = await UserService.Create(user);

        //        if (result.Successed)
        //        {
        //            return View("Login");
        //        }
        //        else
        //        {
        //            ModelState.AddModelError(result.Property, result.Message);
        //        }
        //    }
        //    return View(model);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> Login(LoginModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var user = new User
        //        {
        //            UserName = model.UserName,
        //            Password = model.Password
        //        };
        //        ClaimsIdentity claim = await UserService.Authenticate(user);
        //        if (claim == null)
        //        {
        //            ModelState.AddModelError("", "Неверный логин или пароль.");
        //        }
        //        else
        //        {
        //            AuthenticationManager.SignOut();
        //            AuthenticationManager.SignIn(new AuthenticationProperties { IsPersistent = true }, claim);
        //            return RedirectToAction("Index", "Home");
        //        }
        //    }
        //    return View(model);
        //}

        //public ActionResult Logout()
        //{
        //    AuthenticationManager.SignOut();
        //    return RedirectToAction("Index", "Home");
        //}
    }
}