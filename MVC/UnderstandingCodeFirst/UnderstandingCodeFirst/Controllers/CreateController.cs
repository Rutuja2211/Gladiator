using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnderstandingCodeFirst.Models;

namespace UnderstandingCodeFirst.Controllers
{
    public class CreateController : Controller
    {
        // GET: Create
        public ActionResult Index()
        {
            //MovieContext movieContext = new MovieContext();
            //Movie movie = new Movie();
            //movie.Name = "MI";
            //movie.Duration = 122.2f;
            //movieContext.Movies.Add(movie);
            //movieContext.SaveChanges();
            //Disc disc = new Disc();
            //disc.Cost = 12.3f;
            //disc.Movie = movie;
            //movieContext.Discs.Add(disc);
            //movieContext.SaveChanges();
            ViewBag.Msg = "Done creating";
            return View();
        }

        public ActionResult Another()
        {
            ViewBag.Msg = "In Another";
            return View();
        }
    }
}