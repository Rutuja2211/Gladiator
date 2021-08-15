using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPIDoctorProject.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Remarks { get; set; }

      
        public virtual ICollection<Appointment> Appointments { get; set; }

        public Patient()
        {
        }

        public Patient(int id, string name, int age, string remarks)
        {
            Id = id;
            Name = name;
            Age = age;
            Remarks = remarks;
        }
    }
}