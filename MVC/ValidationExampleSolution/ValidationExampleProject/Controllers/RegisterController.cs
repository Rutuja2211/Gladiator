using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationExampleProject.Models;

namespace ValidationExampleProject.Controllers
{
    public class RegisterController : Controller
    {
        dbDiscShopEntities dse = new dbDiscShopEntities();
        // GET: Register
        public ActionResult RegisterPage()
        {
            List<string> roles = new List<string>() { "Admin","User"};
            List<string> status = new List<string>() { "True", "False" };
            ViewBag.roles = roles;
            ViewBag.status = status;
            return View();
        }

        [HttpPost]
        public ActionResult RegisterPage(user u)
        {
            if (ModelState.IsValid == false)
                return View();
            
            try
            {
                dse.proc_register_user(u.username, u.password, u.name, u.age, u.role,u.isActive);
                dse.SaveChanges();
                TempData["username"] = u.username;
            }

            catch (Exception)
            {
                ViewBag.Error = "Unsuccessful registration. Please try again";
                return View();
            }

            return RedirectToAction("UserLogin","Login");
        }
    }
}