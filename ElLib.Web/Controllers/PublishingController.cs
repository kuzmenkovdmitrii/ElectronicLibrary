using System.Web.Mvc;
using ElLib.BLL.Services.Interfaces;
using ElLib.Common.Entities;
using ElLib.Common.Mapper;
using ElLib.Web.Models;

namespace ElLib.Web.Controllers
{
    public class PublishingController : Controller
    {
        private readonly IPublishingService publishingService;

        public PublishingController(IPublishingService publishingService)
        {
            this.publishingService = publishingService;
        }

        public ActionResult All()
        {
            return View(publishingService.GetAll());
        }

        public ActionResult Info(int? id)
        {
            return View(publishingService.GetById(id));
        }

        [Authorize(Roles = "Admin, Editor")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin, Editor")]
        public ActionResult Create(CreatePublishingModel model)
        {
            if (ModelState.IsValid)
            {
                Publishing publishing = Mapper.Map<CreatePublishingModel, Publishing>(model);
                var result = publishingService.Create(publishing);

                if (result.Successed)
                {
                    return RedirectToAction("All");
                }

                ModelState.AddModelError(result.Property, result.Message);
            }

            return View(model);
        }

        [Authorize(Roles = "Admin, Editor")]
        public ActionResult Edit(int? id)
        {
            Publishing publishing = publishingService.GetById(id);

            return View(Mapper.Map<Publishing, EditPublishingModel>(publishing));
        }

        [HttpPost]
        [Authorize(Roles = "Admin, Editor")]
        public ActionResult Edit(EditPublishingModel model)
        {
            if (ModelState.IsValid)
            {
                Publishing publishing = Mapper.Map<EditPublishingModel, Publishing>(model);
                var result = publishingService.Update(publishing);

                if (result.Successed)
                {
                    return RedirectToAction("All");
                }

                ModelState.AddModelError(result.Property, result.Message);
            }

            return View(model);
        }

        [Authorize(Roles = "Admin, Editor")]
        public ActionResult Delete(int? id)
        {
            var result = publishingService.Delete(id);

            if (result.Successed)
            {
                return RedirectToAction("All");
            }

            ModelState.AddModelError(result.Property, result.Message);

            return View("All");
        }

        public ActionResult AllPublishingsForSelect()
        {
            return PartialView(publishingService.GetAll());
        }

        public JsonResult CheckName(string name)
        {
            var result = publishingService.CheckName(name);

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Search(string query)
        {
            if (query == null)
            {
                query = "";
            }

            return PartialView(publishingService.Search(query));
        }
    }
}