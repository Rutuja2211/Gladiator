using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UnderstandingCodeFirst.Controllers
{
    public class PartialViewController : Controller
    {
        // GET: PartialView
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly] // can be used as partial only, i.e cannot be accessed using url as individual page
        public ActionResult Check()
        {
            ViewBag.Msg = "Hello Check";
            return View();
        }
    }
}