using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstAPIExampleProject.Models
{
    public class MyUser
    {
        public string name { get; set; }
        public int id { get; set; }
        public int age { get; set; }

        public MyUser()
        {
        }

        public MyUser(string name, int id, int age)
        {
            this.name = name;
            this.id = id;
            this.age = age;
        }
    }
}