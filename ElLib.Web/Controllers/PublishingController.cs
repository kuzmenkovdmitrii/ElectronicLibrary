using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElLib.BLL.Service.Interface;
using ElLib.Common.Entity;
using ElLib.Common.Mapper;
using ElLib.Web.Models;

namespace ElLib.Web.Controllers
{
    public class PublishingController : Controller
    {
        IPublishingService publishingService;

        public PublishingController(IPublishingService publishingService)
        {
            this.publishingService = publishingService;
        }

        [HttpGet]
        public ActionResult All()
        {

            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(CreatePublishingModel model)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(EditPublishingModel model)
        {
            return View();
        }

        [HttpPost]
        public void Delete(int id)
        {
            RedirectToAction("All");
        }

        public ActionResult GetById()
        {
            return View();
        }

        public void Get(int id)
        {
            publishingService.GetById(id);
        }
    }
}