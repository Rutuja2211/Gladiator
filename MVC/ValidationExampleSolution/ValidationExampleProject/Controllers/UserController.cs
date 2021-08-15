using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationExampleProject.Models;

namespace ValidationExampleProject.Controllers
{
    public class UserController : Controller
    {
        dbDiscShopEntities dse = new dbDiscShopEntities();
        // GET: User
        public ActionResult UserDisplay()
        {
            return View(dse.users.ToList());
        }
    }
}