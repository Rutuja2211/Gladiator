using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPIDoctorProject.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Exp { get; set; }
        public string Speciality { get; set; }

      
        public virtual ICollection<Appointment> Appointments { get; set; }

        public Doctor()
        {
        }

        public Doctor(int id, string name, int exp, string speciality)
        {
            Id = id;
            Name = name;
            Exp = exp;
            Speciality = speciality;
        }
    }
}