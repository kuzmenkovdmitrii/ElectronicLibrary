using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.WebPages;
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

        public IEnumerable<Author> GetAll()
        {
            return authorService.GetAll();
        }

        public ActionResult Info(int? id)
        {
            if (id != null)
            {
                return View(authorService.GetById(id));
            }

            return null; //TODO redirect to 401
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CreateAuthorModel model)
        {
            if (ModelState.IsValid)
            {
                Author author = Mapper.Map<CreateAuthorModel, Author>(model);
                authorService.Create(author);
                return RedirectToAction("All");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Edit(int? id)
        {
            if (id != null)
            {
                return View(Mapper.Map<Author, EditAuthorModel>(authorService.GetById(id)));
            }
            return null; //TODO redirect to 401
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

        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
                authorService.Delete(id);
                return RedirectToAction("All");
            }

            return null; //TODO redirect to 401
        }

        public ActionResult AllAuthorsForSelect(int[] changed)
        {
            return PartialView(authorService.GetAll());
        }

        public ActionResult Search(string query)
        {
            if (query.IsEmpty())
            {
                query = "";
            }
            //var words = query.Split(' ');

            return PartialView(authorService.GetAll().Where(
                x => x.Name.Contains(query) ||
                     x.LastName.Contains(query) ||
                     x.MiddleName.Contains(query) ||
                     x.Email.Contains(query)).ToList());
        }
    }
}