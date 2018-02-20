using Legendary_Student_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Legendary_Student_API.Services
{
    public class StudentService
    {
        public bool AddStudent(Student s)
        {
            return true;
        }
        public Student GetStudentByStudentID(int StudentID)
        {
            return new Student();
        }

        public List<Student> GetAllStudents()
        {
            return new List<Student>();
        }
    }
}