using System.Linq;
using System.Web.Mvc;
using ElLib.BLL.Services.Interfaces;
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

        public ActionResult All()
        {
            return View(publishingService.GetAll());
        }

        public ActionResult Info(int? id)
        {
            return View(publishingService.GetById(id));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
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

        public ActionResult Edit(int? id)
        {
            Publishing publishing = publishingService.GetById(id);

            return View(Mapper.Map<Publishing, EditPublishingModel>(publishing));
        }

        [HttpPost]
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

        public ActionResult Delete(int? id)
        {
            publishingService.Delete(id);

            return RedirectToAction("All");
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