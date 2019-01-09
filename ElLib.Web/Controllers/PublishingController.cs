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
            if (id != null)
            {
                return View(publishingService.GetById(id));
            }

            return null; //TODO redirect to 401
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
                publishingService.Create(publishing);
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
                Publishing publishing = publishingService.GetById(id);

                return View(Mapper.Map<Publishing, EditPublishingModel>(publishing));
            }

            return null; //TODO redirect to 401
        }

        [HttpPost]
        public ActionResult Edit(EditPublishingModel model)
        {
            if (ModelState.IsValid)
            {
                Publishing publishing = Mapper.Map<EditPublishingModel, Publishing>(model);
                publishingService.Update(publishing);
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
                publishingService.Delete(id);
                return RedirectToAction("All");
            }

            return null; //TODO redirect to 401
        }

        public ActionResult AllPublishingsForSelect()
        {
            return PartialView(publishingService.GetAll());
        }
    }
}