using System.Linq;
using System.Web.Mvc;
using ElLib.BLL.Services.Interfaces;
using ElLib.Common.Entity;
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

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(CreateBookCategoryModel model)
        {
            if (ModelState.IsValid)
            {
                BookCategory bookCategory = Mapper.Map<CreateBookCategoryModel, BookCategory>(model);
                bookCategoryService.Create(bookCategory);
                return RedirectToAction("All");
            }
            else
            {
                return View(model);
            }
        }

        public ActionResult Edit(int id)
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
                bookCategoryService.Update(bookCategory);
                return RedirectToAction("All");
            }
            else
            {
                return View(model);
            }
        }

        public ActionResult Delete(int id)
        {
            bookCategoryService.Delete(id);
            return RedirectToAction("All");
        }

        public ActionResult AllCategoriesForSelect()
        {
            return PartialView(bookCategoryService.GetAll());
        }
    }
}