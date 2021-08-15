using FirstMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCApplication.Controllers
{
    public class EmployeeController : Controller
    {
        static List<Employee> employees = new List<Employee>()
            {new Employee(101, "Ana", 22),
            new Employee(105, "Hana", 25),
            new Employee(102, "Lana", 20),
            new Employee(104, "Dana", 32),
            new Employee(103, "Nana", 40) };

        // GET: Employee
        public ActionResult Index()
        {
            Employee employee = new Employee();
            employee.Id = 101;
            employee.Name = "Ana";
            employee.Age = 22;
            return View(employee);
        }

        public ActionResult List()
        {
            return View(employees);
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee e)
        {
            employees.Add(e);
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            Employee e = employees.Find(emp => emp.Id == id);
            return View(e);
        }

        [HttpPost]
        public ActionResult Update(Employee e)
        {
            int inx = employees.FindIndex(emp => emp.Id == e.Id);
            employees[inx].Name = e.Name;
            employees[inx].Age = e.Age;
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Employee e = employees.Find(emp => emp.Id == id);
            return View(e);
        }

        [HttpPost]
        public ActionResult Delete(Employee e)
        {
            int inx = employees.FindIndex(emp => emp.Id == e.Id);
            employees.RemoveAt(inx);
            return RedirectToAction("List");
        }


    }
}