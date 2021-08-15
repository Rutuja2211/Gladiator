using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using FirstAPIExampleProject.Models;

namespace FirstAPIExampleProject.Controllers
{
    public class UserController : ApiController
    {
        private NorthwindEntities db = new NorthwindEntities();

       
        public List<tblUser> GettblUsers()
        {
            return db.tblUsers.ToList();
        }
    
        public string PosttblUser([FromBody]tblUser tblUser)
        {
            List<tblUser> users = db.tblUsers.ToList();
            int inx = users.FindIndex(u => u.Id == tblUser.Id && u.Password == tblUser.Password);
            if (inx >= 0)
                return "Login succeeded";
            else
                return "Invalid credentials";

        }

    }
}