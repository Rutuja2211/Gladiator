using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCApplication.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public string MyFirstMethod()
        {
            return "Hello Rutu";
        }

        public ActionResult SecondMethod()
        {
            return View();
        }
        public ActionResult MyOwn()
        {
            return View();
        }

        public ActionResult PassDataUsingViewBag()
        {
            ViewBag.Name = " Welcome Rutu"; // Viewbag is dynamic
            return View();
        }

        public ActionResult PassDataUsingViewData()
        {
            ViewData["Name"] = "Rutu";// View Data is static as it is stored in indices
            ViewData["Age"] = 22;
            return View();
        }

        public ActionResult ViewBagVsViewData()
        {
            List<string> names = new List<string>();
            names.Add("Ana");
            names.Add("Hana");
            names.Add("Lana");
            names.Add("Nana");
            names.Add("Bana");

            ViewBag.users = names;
            ViewData["users"] = names;

            return View();
        }
    }
}