using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using ElLib.BLL.Services.Interfaces;
using ElLib.Common.Entity;
using ElLib.Common.Mapper;
using ElLib.Web.Models;

namespace ElLib.Web.Controllers
{
    public class AuthController : Controller
    {
        readonly IAuthService authService;
        readonly IUserService userService;

        public AuthController(IAuthService authService, IUserService userService)
        {
            this.authService = authService;
            this.userService = userService;
        }

        public ActionResult Login()
        {
            return PartialView();
        }

        public ActionResult Registration()
        {
            return PartialView();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Registration(RegisterUserModel model)
        {
            if (ModelState.IsValid)
            {
                var user = Mapper.Map<RegisterUserModel, User>(model);

                var result = await authService.Register(user, model.Password);

                if (result.Successed)
                {
                    return View("Login");
                }

                ModelState.AddModelError(result.Property, result.Message);
            }

            return PartialView();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginUserModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await authService.Authenticate(model.UserName, model.Password);

                if (result.Successed)
                {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(result.Property, result.Message);
            }

            return PartialView();
        }

        public async Task<ActionResult> Logout()
        {
            authService.Logout();

            return RedirectToAction("Index", "Home");
        }

        public JsonResult CheckUserName(string username)
        {
            var users = userService.GetAll();
            var user = users.FirstOrDefault(x => x.UserName == username);
            if (user == null)
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }

            return Json(false, JsonRequestBehavior.AllowGet);
        }

        public JsonResult CheckEmail(string email)
        {
            var users = userService.GetAll();
            var user = users.FirstOrDefault(x => x.Email == email);
            if (user == null)
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }

            return Json(false, JsonRequestBehavior.AllowGet);
        }
    }
}