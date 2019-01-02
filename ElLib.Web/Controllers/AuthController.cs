using System.Threading.Tasks;
using System.Web.Mvc;
using ElLib.BLL.Authentication;
using ElLib.BLL.Services.Interfaces;
using ElLib.Common.Entity;
using ElLib.Common.Mapper;
using ElLib.Web.Models;

namespace ElLib.Web.Controllers
{
    public class AuthController : Controller
    {
        readonly IAuthService authService;

        protected virtual new UserPrincipal User
        {
            get
            {
                return HttpContext.User as UserPrincipal;
            }
        }

        public AuthController(IAuthService authService)
        {
            this.authService = authService;
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Registration()
        {
            return View();
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
                else
                {
                    ModelState.AddModelError(result.Property, result.Message);
                }
            }
            return View(model);
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
                else
                {
                    ModelState.AddModelError(result.Property, result.Message);
                }
            }

            return View(model);
        }

        public async Task<ActionResult> Logout()
        {
            var result = await authService.Logout();

            return RedirectToAction("Index", "Home");
        }
    }
}