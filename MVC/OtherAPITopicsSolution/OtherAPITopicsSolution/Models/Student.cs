using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OtherAPITopicsSolution.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }

        public Student()
        {
        }

        public Student(int id, string name, int score)
        {
            Id = id;
            Name = name;
            Score = score;
        }
    }
}