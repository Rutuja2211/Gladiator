using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstMVCApplication.Models
{
    public class Customer
    {
        public int Id {get;set;}
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }

        public Customer(int id, string name, int age, string phone)
        {
            Id = id;
            Name = name;
            Age = age;
            Phone = phone;
        }

        public Customer()
        {
        }
    }
}