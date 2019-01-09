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

        public ActionResult Info(int? id)
        {
            if (id != null)
            {
                return View(bookCategoryService.GetById(id));
            }

            return null; //TODO redirect to 401
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
                bookCategoryService.Create(bookCategory);
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
                EditBookCategoryModel model = Mapper.Map<BookCategory, EditBookCategoryModel>(bookCategoryService.GetById(id));
                return View(model);
            }

            return null; //TODO redirect to 401
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

        public ActionResult Delete(int? id)
        {
            if (id != null)
            {
                bookCategoryService.Delete(id);
                return RedirectToAction("All");
            }

            return null; //TODO redirect to 401
        }

        public ActionResult AllCategoriesForSelect()
        {
            return PartialView(bookCategoryService.GetAll());
        }
    }
}