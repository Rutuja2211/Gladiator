using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnderstandingEFSolution.Models;

namespace UnderstandingEFSolution.Controllers
{
    public class EFCustomerController : Controller
    {
        NorthwindEntities entities = new NorthwindEntities();
        // GET: EFCustomer
        public ActionResult Index()
        {
            return View(entities.Customers);
        }
    }
}