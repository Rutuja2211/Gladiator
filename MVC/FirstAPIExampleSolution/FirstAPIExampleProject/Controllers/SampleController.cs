using FirstAPIExampleProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstAPIExampleProject.Controllers
{
    public class SampleController : ApiController
    {
        //[HttpGet]
        //public string sayHello()
        //{
        //    return "Hello dear";
        //}

        [HttpGet]
        public string sayHelloAnother(int id)
        {
            return "Hello Another "+id;
        }

        [HttpGet]
        public string sayHelloAnother(int id, int age)
        {
           
            return "Hello Another " + id + " " + age;
        }

        [HttpGet]
        public string sayHelloAnother(string name)
        {
            
            return "Hello Another " + name;
        }

        [HttpGet]
        public MyUser sayHelloAnother(string name,int id, int age)
        {
            MyUser user = new MyUser(name,id,age);
            return user;
        }

        //[HttpGet]
        //public List<User> sayHelloAnother()
        //{
        //    List<User> users = new List<User>();
        //    users.Add(new User("Rutu",101,21));
        //    users.Add(new User("Sonu", 105, 20));
        //    users.Add(new User("Monu", 107, 25));
        //    return users;
        //}

        [HttpPut]
        public string HelloPut()
        {

            return "This is Put ";
        }
        [HttpPost]
        public string HelloPost()
        {

            return "This is Post ";
        }

        [HttpDelete]
        public string HelloDelete()
        {

            return "This is Delete ";
        }




    }
}
