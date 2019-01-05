using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using ElLib.BLL.Services.Interfaces;
using ElLib.Common.Entity;
using ElLib.Web.Models;

namespace ElLib.Web.Controllers
{
    public class BookController : Controller
    {
        readonly IBookService bookService;
        readonly ILanguageService languageService;
        readonly IPublishingService publishingService;
        readonly IAuthorService authorService;
        readonly IBookCategoryService bookCategoryService;
        readonly IUploadService uploadService;

        public BookController(
            IBookService bookService, 
            ILanguageService languageService,
            IPublishingService publishingService,
            IAuthorService authorService,
            IBookCategoryService bookCategoryService,
            IUploadService uploadService)
        {
            this.bookService = bookService;
            this.languageService = languageService;
            this.publishingService = publishingService;
            this.authorService = authorService;
            this.bookCategoryService = bookCategoryService;
            this.uploadService = uploadService;
        }

        public ActionResult All()
        {
            return View();
        }

        public ActionResult Info(int id = 15)
        {
            return View(bookService.GetById(id));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CreateBookModel model)
        {
            Book book = new Book()
            {
                Name = model.Name,
                Language = languageService.GetById(model.Language),
                Publishings = publishingService.GetAll().Where(x => model.Publishings.Contains(x.Id)).ToList(),
                Authors = authorService.GetAll().Where(x => model.Authors.Contains(x.Id)).ToList(),
                Categories = bookCategoryService.GetAll().Where(x => model.Categories.Contains(x.Id)).ToList(),
                File = new Url(model.File),
                Picture = new Url(model.Picture),
            };

            var result = bookService.Create(book);

            if (result.Successed)
            {
                RedirectToAction("All", "Book");
            }

            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        public string UploadPicture(string path)
        {
            //HttpPostedFileBase picture = null;
            //byte[] infoInBytes = new byte[picture.ContentLength];
            //picture.InputStream.Read(infoInBytes, 0, picture.ContentLength);
            return uploadService.UploadPicture(path);
        }

        public string UploadDocument(string path)
        {
            //HttpPostedFileBase picture = null;
            //byte[] infoInBytes = new byte[picture.ContentLength];
            //picture.InputStream.Read(infoInBytes, 0, picture.ContentLength);
            return uploadService.UploadDocument(path);
        }
    }
}