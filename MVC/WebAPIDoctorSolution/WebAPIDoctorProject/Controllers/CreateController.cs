using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIDoctorProject.Models;

namespace WebAPIDoctorProject.Controllers
{
    public class CreateController : ApiController
    {
        public void Get()
        {
            HealthContext healthContext = new HealthContext();
            Doctor doctor = new Doctor(101,"Ana",10,"Pediatric");
            healthContext.Doctors.Add(doctor);
            healthContext.SaveChanges();
            Patient patient = new Patient();
            Appointment appointment = new Appointment();
        }
        

    }
}
