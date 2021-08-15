using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnderstandingEFSolution.Models;

namespace UnderstandingEFSolution.Controllers
{
    public class OrderController : Controller
    {
        NorthwindEntities nw = new NorthwindEntities();
        //List<Product> products = new List<Product>()
        //{
        //    new Product(1,"Pen",25.0),
        //    new Product(2,"Pencil",5.50),
        //    new Product(3,"Scale",50.25),
        //};

        //// GET: Order
        //public ActionResult SingleOrder()
        //{
        //    Order order = new Order();
        //    order.Id = 101;
        //    order.Products = products;
        //    var sum = (from p in order.Products select p.Price).Sum();
        //    ViewBag.Total = sum;
        //    return View(order);
        //}

        public ActionResult DisplayAllOrders()
        {
            List<Order> orders = nw.Orders.ToList();
            orders.Sort(new SortLogic());
            return View(orders);
        }

        public ActionResult Details(int id)
        {
            Order order = nw.Orders.Where(o=>o.OrderID==id).First(); 
            return View(order);
        }

        public ActionResult Edit(int id)
        {
            Order order = nw.Orders.Where(o => o.OrderID == id).First();
            return View(order);
        }

        [HttpPost]
        public ActionResult Edit(Order order)
        {
            //Order MyOrder = nw.Orders.Where(o => o.OrderID == order.OrderID).First();
            //MyOrder = order;
            nw.Entry(order).State=System.Data.Entity.EntityState.Modified;
            nw.SaveChanges();
            return RedirectToAction("DisplayAllOrders");
        }

    }
}