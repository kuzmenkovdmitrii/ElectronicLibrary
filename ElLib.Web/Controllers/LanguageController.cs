using System.Web.Mvc;
using ElLib.BLL.Services.Interfaces;
using ElLib.Common.Entities;
using ElLib.Common.Mapper;
using ElLib.Web.Models;

namespace ElLib.Web.Controllers
{
    public class LanguageController : Controller
    {
        readonly ILanguageService languageService;

        public LanguageController(ILanguageService languageService)
        {
            this.languageService = languageService;
        }

        public ActionResult All()
        {
            return View(languageService.GetAll());
        }

        [Authorize(Roles = "Admin, Editor")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin, Editor")]
        public ActionResult Create(CreateLanguageModel model)
        {
            if (ModelState.IsValid)
            {
                Language language = Mapper.Map<CreateLanguageModel, Language>(model);
                var result = languageService.Create(language);

                if (result.Successed)
                {
                    return RedirectToAction("All");
                }

                ModelState.AddModelError(result.Property, result.Message);
            }

            return View(model);
        }

        [Authorize(Roles = "Admin, Editor")]
        public ActionResult Edit(int? id)
        {
            return View(Mapper.Map<Language, EditLanguageModel>(languageService.GetById(id)));
        }

        [HttpPost]
        [Authorize(Roles = "Admin, Editor")]
        public ActionResult Edit(EditLanguageModel model)
        {
            if (ModelState.IsValid)
            {
                Language language = Mapper.Map<EditLanguageModel, Language>(model);
                var result = languageService.Update(language);

                if (result.Successed)
                {
                    return RedirectToAction("All");
                }

                ModelState.AddModelError(result.Property, result.Message);
            }

            return View(model);
        }

        [Authorize(Roles = "Admin, Editor")]
        public ActionResult Delete(int? id)
        {
            languageService.Delete(id);

            return RedirectToAction("All");
        }

        public ActionResult AllLanguagesForSelect()
        {
            return PartialView(languageService.GetAll());
        }

        public JsonResult CheckName(string name)
        {
            var result = languageService.CheckName(name);

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}