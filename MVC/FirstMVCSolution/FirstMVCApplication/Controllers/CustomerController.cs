using FirstMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCApplication.Controllers
{
    public class CustomerController : Controller
    {
        static List<Customer> customers = new List<Customer>() {
        new Customer(101,"Ana",22,"66666-66666"),
            new Customer(103, "Lana", 45, "44444-44444"),
            new Customer(105, "Nana", 36, "22222-2222"),
            new Customer(106, "Sana", 25, "11111-11111"),
            new Customer(102, "Dana", 32, "77777-77777")};
        // GET: Customer

        public ActionResult List()
        {
            return View(customers);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer c)
        {
            customers.Add(c);
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            Customer customer = customers.Find(cust=>cust.Id==id);
            return View(customer);
        }

        [HttpPost]
        public ActionResult Update(Customer c)
        {
            int inx = customers.FindLastIndex(cust=>cust.Id==c.Id);
            customers[inx].Name = c.Name;
            customers[inx].Age = c.Age;
            customers[inx].Phone = c.Phone;

            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Customer customer = customers.Find(cust => cust.Id == id);
            return View(customer);
        }

        [HttpPost]
        public ActionResult Delete(Customer c)
        {
            //int inx = customers.FindLastIndex(cust => cust.Id == c.Id);
            //customers.RemoveAt(inx);
            customers.Remove(c);
            return RedirectToAction("List");
        }


    }
}