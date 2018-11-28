using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElLib.Common.Entity;
using ElLib.Common.Mapper;
using ElLib.Web.Models;

namespace ElLib.Web.Controllers
{
    public class BookCategoryController : Controller
    {
        [HttpGet]
        public ActionResult All()
        {
            BookCategory b1 = new BookCategory()
            {
                Name = "Комедия",
                Description = "Какая-то комедия вот так вот так как есть"
            };

            BookCategory b2 = new BookCategory()
            {
                Name = "Ужасы",
                Description = "Какая-то комедия вот так вот так как есть"
            };

            BookCategory b3 = new BookCategory()
            {
                Name = "Детектив",
                Description = "Какая-то комедия вот так вот так как есть"
            };

            BookCategory b4 = new BookCategory()
            {
                Name = "Преключение",
                Description = "Какая-то комедия вот так вот так как есть"
            };

            BookCategory b5 = new BookCategory()
            {
                Name = "Фантастика",
                Description = "Какая-то комедия вот так вот так как есть"
            };

            IEnumerable<BookCategory> list = new List<BookCategory>() { b1,b2,b3,b4,b5 };

            return View(Mapper.Map<BookCategory, BookCategoryModel>(list));
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(CreateBookCategoryModel model)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id)
        {
            ViewData.Model = id;
            return View();
        }

        [HttpPost]
        public ActionResult Edit(EditBookCategoryModel model)
        {
            return View();
        }

        [HttpPost]
        public void Delete(int id)
        {
            RedirectToAction("All");
        }
    }
}