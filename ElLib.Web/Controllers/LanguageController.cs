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
    public class LanguageController : Controller
    {
        IEnumerable<Language> list;

        private void Init()
        {
            Language l1 = new Language()
            {
                Id = 1,
                Name = "English",
            };

            Language l2 = new Language()
            {
                Id = 2,
                Name = "Russin",
            };

            Language l3 = new Language()
            {
                Id = 3,
                Name = "Ukraine",
            };

            Language l4 = new Language()
            {
                Id = 4,
                Name = "Poland",
            };

            list = new List<Language>() { l1, l2, l3, l4 };
        }

        [HttpGet]
        public ActionResult All()
        {
           
            Init();
            return View(Mapper.Map<Language, LanguageModel>(list));
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(CreateLanguageModel model)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Init();
            return View(Mapper.Map<Language,EditLanguageModel>(list.FirstOrDefault(x=>x.Id == id)));
        }

        [HttpPost]
        public ActionResult Edit(EditLanguageModel model)
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