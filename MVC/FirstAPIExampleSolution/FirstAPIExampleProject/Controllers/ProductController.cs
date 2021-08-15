using FirstAPIExampleProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstAPIExampleProject.Controllers
{
    public class ProductController : ApiController
    {
        private NorthwindEntities db = new NorthwindEntities();

        public IQueryable GetProducts()
        {
            return db.Products;
        }

        public List<Product> GetProductsLessThan(decimal price)
        {
         
            return db.Products.ToList().Where(p => p.UnitPrice < price).ToList();
        }


    }
}
