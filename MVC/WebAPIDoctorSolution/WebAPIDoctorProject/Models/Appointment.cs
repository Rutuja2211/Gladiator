using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPIDoctorProject.Models
{
    public class Appointment
    {   
        [Key]
        public int Id { get; set; }
        [Column("DoctorId")]
        public virtual Doctor Doctor { get; set; }

        [Column("PatientId")]
        public virtual Patient Patient { get; set; }

        public DateTime Date { get; set; }
    }
}