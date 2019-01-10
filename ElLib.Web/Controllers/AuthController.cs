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
        readonly IUserService userService;

        private UserPrincipal CurrentUser
        {
            get
            {
                return HttpContext.User as UserPrincipal;
            }
        }

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

        public ActionResult Profile()
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
            await authService.Logout();

            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        public ActionResult EditUserName()
        {
            EditUserNameModel model = new EditUserNameModel()
            {
                Id = CurrentUser.Id,
                UserName = CurrentUser.UserName
            };

            return PartialView(model);
        }

        [Authorize]
        [HttpPost]
        public ActionResult EditUserName(EditUserNameModel model)
        {
            if (CurrentUser.UserName == model.UserName)
            {
                ModelState.AddModelError("UserName", "Это ваш текущий логин");
            }

            if (ModelState.IsValid)
            {
                User user = userService.GetById(CurrentUser.Id);

                user.UserName = model.UserName;

                var result = userService.Update(user);

                if (result.Successed)
                {
                    return RedirectToAction("Profile");
                }

                ModelState.AddModelError(result.Property, result.Message);
            }

            return RedirectToAction("Profile");
        }

        [Authorize]
        public ActionResult EditEmail()
        {
            EditUserEmailModel model = new EditUserEmailModel()
            {
                Id = CurrentUser.Id,
                Email = CurrentUser.Email
            };

            return PartialView(model);
        }

        [Authorize]
        [HttpPost]
        public ActionResult EditEmail(EditUserEmailModel model)
        {
            if (CurrentUser.Email == model.Email)
            {
                ModelState.AddModelError("Email", "Это ваш текущий Email");
            }

            if (ModelState.IsValid)
            {
                User user = userService.GetById(CurrentUser.Id);

                user.Email = model.Email;

                var result = userService.Update(user);

                if (result.Successed)
                {
                    return RedirectToAction("Profile");
                }

                ModelState.AddModelError(result.Property, result.Message);
            }

            return RedirectToAction("Profile");
        }

        [Authorize]
        public ActionResult EditPassword()
        {
            return PartialView();
        }

        [Authorize]
        [HttpPost]
        public ActionResult EditPassword(EditUserPasswordModel model)
        {
            if (ModelState.IsValid)
            {
                User user = userService.GetById(CurrentUser.Id);

                var result = userService.UpdatePassword(user, model.OldPassword, model.NewPassword);

                if (result.Successed)
                {
                    return RedirectToAction("Profile");
                }

                ModelState.AddModelError(result.Property, result.Message);
            }

            return RedirectToAction("Profile");
        }

        public JsonResult CheckUserName(string username)
        {
            var result = userService.CheckUserName(username);

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult CheckEmail(string email)
        {
            var result = userService.CheckEmail(email);

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}