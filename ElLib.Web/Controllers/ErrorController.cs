using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElLib.Web.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult ValidationError(ModelErrorCollection errors)
        {
            ICollection<string> messages = new List<string>();

            foreach (var error in errors)
            {
                messages.Add(error.ErrorMessage);
            }

            return PartialView(messages);
        }
    }
}