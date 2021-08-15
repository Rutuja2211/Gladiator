using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnderstandingEFSolution.Models;

namespace UnderstandingEFSolution.Controllers
{
    public class ProductController : Controller
    {
        List<Product> GetProductsFromDatabase()
        {
            List<Product> products = new List<Product>();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["adoConn"].ConnectionString);
            SqlDataAdapter daProducts = new SqlDataAdapter("Select ProductId,ProductName,UnitPrice from Products",conn);
            DataSet dsProducts = new DataSet();
            daProducts.Fill(dsProducts);
            foreach (DataRow item in dsProducts.Tables[0].Rows)
            {
                //Product p = new Product(Convert.ToInt32(item[0]),item[1].ToString(),Convert.ToDouble(item[2]));
                //products.Add(p);

            }
            return products;
        }
        // GET: Product
        public ActionResult List()
        {
            return View(GetProductsFromDatabase());
        }
    }
}