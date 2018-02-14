using Legendary_Student_API.Models.Test;
using System.Collections.Generic;

namespace Legendary_Student_API.Models
{
    public class Dashboard
    {
        public Dashboard()
        {
            Schools = new List<School>();
            Students = new List<Student>();
            TopStudents = new List<Student>();
            NewTest = new List<NewTest>();
        }
        public List<School> Schools { get; set; }
        public List<Student> Students { get; set; }
        public List<Student> TopStudents { get; set; }
        public List<NewTest> NewTest { get; set; }
    }
}