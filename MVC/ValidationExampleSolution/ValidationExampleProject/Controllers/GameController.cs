using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationExampleProject.Models;

namespace ValidationExampleProject.Controllers
{
    public class GameController : Controller
    {
        dbDiscShopEntities dse = new dbDiscShopEntities();
        // GET: Game
        public ActionResult GamesMainPage()
        {
            ViewBag.games = dse.proc_games().ToList();
            return View();
        }

        [HttpPost]
        public ActionResult GamesMainPage(Game game)
        {
            return RedirectToAction("GamePage",game);
        }

        public ActionResult GamePage(Game game)
        {   
            return View(dse.proc_users_score(game.Id));
        }
    }
}   