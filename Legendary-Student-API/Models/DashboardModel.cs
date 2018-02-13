using Legendary_Student_API.Models.TestModels;
using System.Collections.Generic;

namespace Legendary_Student_API.Models
{
    public class DashboardModel
    {
        public List<SchoolRegistrationModel> Schools { get; set; }
        public List<StudentRegistrationModel> Students { get; set; }
        public List<StudentRegistrationModel> TopStudents { get; set; }
        public List<NewTestModel> NewTest { get; set; }
    }
}