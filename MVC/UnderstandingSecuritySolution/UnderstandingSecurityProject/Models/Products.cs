using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnderstandingSecurityProject.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        public Products(int id, string name, float price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}