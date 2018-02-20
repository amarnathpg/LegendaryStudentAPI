using Legendary_Student_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Legendary_Student_API.Services
{
    public class SchoolService
    {
        public bool AddSchool(School s)
        {
            return true;
        }
        public School GetSchoolBySchoolID(int SchoolID)
        {
            return new School();
        }

        public List<School> GetAllSchools()
        {
            return new List<School>();
        }
    }
}