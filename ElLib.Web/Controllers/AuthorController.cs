﻿using System.Collections.Generic;
using System.Web.Mvc;
using ElLib.BLL.Services.Interfaces;
using ElLib.Common.Entities;
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
            return View(authorService.GetById(id));
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

                var result = authorService.Create(author);

                if (result.Successed)
                {
                    return RedirectToAction("All");
                }

                ModelState.AddModelError(result.Property, result.Message);
            }

            return View();
        }

        public ActionResult Edit(int? id)
        {
            return View(Mapper.Map<Author, EditAuthorModel>(authorService.GetById(id)));
        }

        [HttpPost]
        public ActionResult Edit(EditAuthorModel model)
        {
            if (ModelState.IsValid)
            {
                Author author = Mapper.Map<EditAuthorModel, Author>(model);

                var result = authorService.Update(author);

                if (result.Successed)
                {
                    return RedirectToAction("All");
                }

                ModelState.AddModelError(result.Property, result.Message);
            }

            return View();
        }

        public ActionResult Delete(int? id)
        {
            authorService.Delete(id);
            return RedirectToAction("All");
        }

        public ActionResult AllAuthorsForSelect()
        {
            return PartialView(authorService.GetAll());
        }

        public ActionResult Search(string query)
        {
            if (query == null)
            {
                query = "";
            }

            return PartialView(authorService.Search(query));
        }
    }
}