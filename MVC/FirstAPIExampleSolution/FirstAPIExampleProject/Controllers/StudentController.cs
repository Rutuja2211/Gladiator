using FirstAPIExampleProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstAPIExampleProject.Controllers
{
    public class StudentController : ApiController
    {
        public static List<Student> students = new List<Student>() {
            new Student(101,"Ana"),
            new Student(105,"Lana"),
            new Student(108,"Hana"),
        };

        public List<Student> GetStudents()
        {
            return students;
        }

        public Student GetStudent(int id)
        {
            Student student = students.Find(s=>s.Id==id);
            return student;
        }

        public string PostStudent(Student student)
        {
            students.Add(student);
            return "Student added successfully";
        }

        public string PutStudent(int id,Student student)
        {
            int inx = students.FindIndex(s=>s.Id==id);
            if (inx >= 0)
            {
                students[inx] = student;
                return "Student modified successfully";
            }
            else
                return "Student not found";
        }

        public string DeleteStudent([FromBody]int id)
        {
            int inx = students.FindIndex(s => s.Id == id);
            if (inx >= 0)
            {
                students.RemoveAt(inx);
                return "Student deleted successfully";
            }
            else
                return "Student not found";
        }

    }
}
