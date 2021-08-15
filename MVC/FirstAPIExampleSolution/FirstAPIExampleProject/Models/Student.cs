using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace FirstAPIExampleProject.Models
{   
    [DataContract]
    public class Student
    {   
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }

        public Student()
        {
        }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}