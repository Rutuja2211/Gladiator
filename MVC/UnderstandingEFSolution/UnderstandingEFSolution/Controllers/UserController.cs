using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnderstandingEFSolution.Models;

namespace UnderstandingEFSolution.Controllers
{
    public class UserController : Controller
    {
        NorthwindEntities nw = new NorthwindEntities();
        // GET: User
        public ActionResult List()
        {   
            return View(nw.tblUsers);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(tblUser user)
        {
            nw.tblUsers.Add(user);
            nw.SaveChanges();
            return RedirectToAction("List");
        }
    }
}