using NewMVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewMVCProject.Controllers
{
    public class MoviesController : Controller
    {
        dbDiscShopEntities dse = new dbDiscShopEntities();
        // GET: Movies
        public ActionResult Index()
        {
            return View(dse.movies);
        }
    }
}