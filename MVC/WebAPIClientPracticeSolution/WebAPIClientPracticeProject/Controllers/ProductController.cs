using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebAPIClientPracticeProject.Models;

namespace WebAPIClientPracticeProject.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public async Task<ActionResult> DisplayProducts()
        {
             List<Product> products = new List<Product>();
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:64410/");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync("api/Product");
                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync().Result;
                    products = JsonConvert.DeserializeObject<List<Product>>(result);
                }
                return View(products);
            
        }
    }
}