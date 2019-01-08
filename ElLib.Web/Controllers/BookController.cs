﻿using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web.Mvc;
using ElLib.BLL.Services.Interfaces;
using ElLib.Common.Entity;
using ElLib.Common.Mapper;
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

        public ActionResult Info(int id)
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

        public ActionResult Edit(int id)
        {
            Book book = bookService.GetById(id);
            EditBookModel model = new EditBookModel()
            {
                Id = id,
                Name = book.Name,
                Language = book.Language.Id,
                Authors = book.Authors.Select(x => x.Id).ToArray(),
                Categories = book.Categories.Select(x => x.Id).ToArray(),
                Publishings = book.Publishings.Select(x => x.Id).ToArray(),
                File = book.File.Value,
                Picture = book.Picture.Value
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(EditAuthorModel model)
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

        public ActionResult Search(SearchBooksParametersModel model)
        {
            if (string.IsNullOrEmpty(model.Query))
            {
                model.Query = "";
            }

            IEnumerable<Book> list = bookService.GetAll().Where(x => x.Name.Contains(model.Query)).ToList();


            if (list == null)
            {
                return PartialView(list);
            }

            if (model.Publishings != null)
            {
                ICollection<Book> bufferList = new List<Book>();

                foreach (var book in list)
                {
                    foreach (var publishing in book.Publishings)
                    {
                        if (model.Publishings.Contains(publishing.Id))
                        {
                            bufferList.Add(book);
                        }
                    }
                }

                bufferList = bufferList.Distinct().ToList();
                list = bufferList.Intersect(bufferList);
            }

            if (model.Languages != null)
            {
                ICollection<Book> bufferList = new List<Book>();

                foreach (var book in list)
                {
                    if (model.Languages.Contains(book.Language.Id))
                    {
                        bufferList.Add(book);
                    }
                }

                bufferList = bufferList.Distinct().ToList();
                list = bufferList.Intersect(bufferList);
            }

            if (model.Authors != null)
            {
                ICollection<Book> bufferList = new List<Book>();

                foreach (var book in list)
                {
                    foreach (var author in book.Authors)
                    {
                        if (model.Authors.Contains(author.Id))
                        {
                            bufferList.Add(book);
                        }
                    }
                }

                bufferList = bufferList.Distinct().ToList();
                list = bufferList.Intersect(bufferList);
            }

            if (model.Categories != null)
            {
                ICollection<Book> bufferList = new List<Book>();

                foreach (var book in list)
                {
                    foreach (var category in book.Categories)
                    {
                        if (model.Categories.Contains(category.Id))
                        {
                            bufferList.Add(book);
                        }
                    }
                }

                bufferList = bufferList.Distinct().ToList();
                list = bufferList.Intersect(bufferList);
            }

            return PartialView(list);
        }
    }
}