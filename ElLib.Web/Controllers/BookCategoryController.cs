using System.Web.Mvc;
using ElLib.BLL.Services.Interfaces;
using ElLib.Common.Entities;
using ElLib.Common.Mapper;
using ElLib.Web.Models;

namespace ElLib.Web.Controllers
{
    public class BookCategoryController : Controller
    {
        readonly IBookCategoryService bookCategoryService;

        public BookCategoryController(IBookCategoryService bookCategoryService)
        {
            this.bookCategoryService = bookCategoryService;
        }

        public ActionResult All()
        {
            return View(bookCategoryService.GetAll());
        }

        public ActionResult Info(int? id)
        {
            return View(bookCategoryService.GetById(id));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CreateBookCategoryModel model)
        {
            if (ModelState.IsValid)
            {
                BookCategory bookCategory = Mapper.Map<CreateBookCategoryModel, BookCategory>(model);

                var result = bookCategoryService.Create(bookCategory);

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
            EditBookCategoryModel model = Mapper.Map<BookCategory, EditBookCategoryModel>(bookCategoryService.GetById(id));
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(EditBookCategoryModel model)
        {
            if (ModelState.IsValid)
            {
                BookCategory bookCategory = Mapper.Map<EditBookCategoryModel, BookCategory>(model);
                var result = bookCategoryService.Update(bookCategory);

                if (result.Successed)
                {
                    return RedirectToAction("All");
                }

                ModelState.AddModelError(result.Property, result.Message);
            }

            return View(model);
        }

        public ActionResult Delete(int? id)
        {
            bookCategoryService.Delete(id);
            return RedirectToAction("All");
        }

        public ActionResult AllCategoriesForSelect()
        {
            return PartialView(bookCategoryService.GetAll());
        }

        public ActionResult Search(string query)
        {
            if (query == null)
            {
                query = "";
            }

            return PartialView(bookCategoryService.Search(query));
        }

        public JsonResult CheckName(string name)
        {
            var result = bookCategoryService.CheckName(name);

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}