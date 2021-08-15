using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationExampleProject.Models;

namespace ValidationExampleProject.Controllers
{
    public class LoginController : Controller
    {
        dbDiscShopEntities dse = new dbDiscShopEntities();
        // GET: Login
        public ActionResult UserLogin()
        {
            if (TempData["username"] != null)
            {
                user u = new user();
                u.username = TempData["username"].ToString();//read once then it gets deleted so cannot be available to next request
                //u.username = TempData.Peek("username").ToString();//here no need to keep it
                TempData.Keep();
                return View(u);
            }

            ViewBag.Error = "";
            return View();
        }

        [HttpPost]
        public ActionResult UserLogin(user u)
        {
            if (ModelState.IsValid == false)
                return View();
            proc_LoginCheck_Result userdata = null;
            try
            {
                userdata = dse.proc_LoginCheck(u.username, u.password).First();
            }

            catch (Exception)
            {
                ViewBag.Error = "Invalid username or password";
                return View();
            }

            return RedirectToAction("UserHome", userdata);
        }

        public ActionResult UserHome(proc_LoginCheck_Result u)
        {
            return View(u);
        }
    }
}