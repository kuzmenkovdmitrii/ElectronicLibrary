using System;
using System.Collections.Generic;
using System.Linq;
using ElLib.Common.Entities.WCF;
using System.Web.Mvc;
using ElLib.BLL.Services.Interfaces;

namespace ElLib.Web.Controllers
{
    public class AdvertisingController : Controller
    {
        private readonly IAdvertisingService advertisingService;

        public AdvertisingController(IAdvertisingService advertisingService)
        {
            this.advertisingService = advertisingService;
        }

        []
        public ActionResult Advertising()
        {
            return PartialView(advertisingService.GetRandomByCount(6));
        }
    }
}