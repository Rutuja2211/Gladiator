using OtherAPITopicsSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace OtherAPITopicsSolution.Controllers
{
    [EnableCors(origins: "http://localhost:59332/", headers: "*", methods: "*")]
    public class StudentController : ApiController
    {   
        static List<Student> students = new List<Student>() {
            new Student(1,"Ana",75),
            new Student(5,"Hana",95),
            new Student(7,"Dana",88)
        };
        // GET: api/Student
        public List<Student> Get()
        {
            return students;
        }

        // GET: api/Student/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Student
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
