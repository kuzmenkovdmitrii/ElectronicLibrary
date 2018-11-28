using System.Collections.Generic;
using System.Web.Mvc;
using ElLib.Common.Entity;
using ElLib.Common.Mapper;
using ElLib.Web.Models;

namespace ElLib.Web.Controllers
{
    public class AuthorController : Controller
    {
        [HttpGet]
        public ActionResult All()
        {
            Author a1 = new Author()
            {
                Email = "dsada@mail.ru",
                Name = "Dida",
                LastName = "Kuzmenkov",
                MiddleName = "Aleksandrovich"
            };

            Author a2 = new Author()
            {
                Email = "dsada@mail.ru",
                Name = "Kirill",
                LastName = "Kuzmenkov",
                MiddleName = "Aleksandrovich"
            };

            Author a3 = new Author()
            {
                Email = "dsada@mail.ru",
                Name = "Sergei",
                LastName = "Kuzmenkov",
                MiddleName = "Aleksandrovich"
            };

            Author a4 = new Author()
            {
                Email = "dsada@mail.ru",
                Name = "Andrei",
                LastName = "Kuzmenkov",
                MiddleName = "Aleksandrovich"
            };

            IEnumerable<Author> list = new List<Author>() {a1, a2, a3, a4};

            return View(Mapper.Map<Author,AuthorModel>(list));
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(CreateAuthorModel model)
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
        public ActionResult Edit(EditAuthorModel model)
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