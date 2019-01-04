using System.Web.Mvc;
using ElLib.BLL.Services.Interfaces;
using ElLib.Common.Entity;
using ElLib.Common.Mapper;
using ElLib.Web.Models;

namespace ElLib.Web.Controllers
{
    public class AuthorController : Controller
    {
        IAuthorService authorService;

        public AuthorController(IAuthorService authorService)
        {
            this.authorService = authorService;
        }

        public ActionResult All()
        {
            return View(authorService.GetAll());
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(CreateAuthorModel model)
        {
            if (ModelState.IsValid)
            {
                Author author = Mapper.Map<CreateAuthorModel, Author>(model);
                authorService.Create(author);
                return RedirectToAction("All");
            }
            else
            {
                return View(model);
            }
        }

        public ActionResult Edit(int id)
        {
            return View(Mapper.Map<Author,EditAuthorModel>(authorService.GetById(id)));
        }

        [HttpPost]
        public ActionResult Edit(EditAuthorModel model)
        {
            if (ModelState.IsValid)
            {
                Author author = Mapper.Map<EditAuthorModel, Author>(model);
                authorService.Update(author);
                return RedirectToAction("All");
            }
            else
            {
                return View(model);
            }
        }

        public ActionResult Delete(int id)
        {
            authorService.Delete(id);
            return RedirectToAction("All");
        }

        public ActionResult AllAuthorsForSelect()
        {
            return PartialView(authorService.GetAll());
        }
    }
}