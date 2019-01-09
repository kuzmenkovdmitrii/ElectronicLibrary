using System.Web.Mvc;
using ElLib.BLL.Services.Interfaces;
using ElLib.Common.Entity;
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

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CreateLanguageModel model)
        {
            if (ModelState.IsValid)
            {
                Language language = Mapper.Map<CreateLanguageModel, Language>(model);
                languageService.Create(language);
                return RedirectToAction("All");
            }
            else
            {
                return View(model);
            }
        }

        public ActionResult Edit(int? id)
        {
            if (id != null)
            {
                return View(Mapper.Map<Language, EditLanguageModel>(languageService.GetById(id)));
            }

            return null; //TODO redirect to 401
        }

        [HttpPost]
        public ActionResult Edit(EditLanguageModel model)
        {
            if (ModelState.IsValid)
            {
                Language language = Mapper.Map<EditLanguageModel, Language>(model);
                languageService.Update(language);
                return RedirectToAction("All");
            }
            else
            {
                return View(model);
            }
        }

        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
                languageService.Delete(id);
                return RedirectToAction("All");
            }

            return null; //TODO redirect to 401
        }

        public ActionResult AllLanguagesForSelect()
        {
            return PartialView(languageService.GetAll());
        }
    }
}