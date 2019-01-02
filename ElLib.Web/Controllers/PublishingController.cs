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

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(CreatePublishingModel model)
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

        public ActionResult Edit(int id)
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
                publishingService.Update(publishing);
                return RedirectToAction("All");
            }
            else
            {
                return View(model);
            }
        }

        public ActionResult Delete(int id)
        {
            publishingService.Delete(id);
            return RedirectToAction("All");
        }
    }
}