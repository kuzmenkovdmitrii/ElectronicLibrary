using System.Web.Mvc;
using ElLib.BLL.Service.Interface;
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

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(CreateLanguageModel model)
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

        public ActionResult Edit(int id)
        {
            return View(Mapper.Map<Language, EditLanguageModel>(languageService.GetById(id)));
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

        [HttpPost]
        public void Delete(int id)
        {
            languageService.Delete(id);
            RedirectToAction("All");
        }
    }
}