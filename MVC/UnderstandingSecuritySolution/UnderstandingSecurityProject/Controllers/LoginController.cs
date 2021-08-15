using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using UnderstandingSecurityProject.Models;

namespace UnderstandingSecurityProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult UserLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UserLogin(User u)
        {
            if (u.Username.Length == 4 && u.Password == "1234")
            {
                TempData["username"] = u.Username;
                FormsAuthentication.SetAuthCookie(u.Username, false);
                return RedirectToAction("DisplayProducts", "Product");
            }

            else
            {
                ViewBag.Msg = "Invalid username or password";
                return View();
            }


        }
    }
}