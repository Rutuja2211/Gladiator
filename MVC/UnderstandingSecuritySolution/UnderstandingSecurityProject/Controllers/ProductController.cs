using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnderstandingSecurityProject.Models;

namespace UnderstandingSecurityProject.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult DisplayProducts()
        {
            List<Products> products = new List<Products>()
            {
                new Products(101,"Pen",15.0f),
                new Products(102,"Pencil",10.0f),
                new Products(103,"Scale",5.5f),
            };
            return View(products);
        }

        //[HandleError]
        [HandleError(ExceptionType =typeof(DivideByZeroException),View="DBZError")]
        [AllowAnonymous]
        public ActionResult Another()
        {
            int a = 10, b = 0, c = 0;
            c = a / b;
            throw new Exception();
            return View();
        }
    }
}