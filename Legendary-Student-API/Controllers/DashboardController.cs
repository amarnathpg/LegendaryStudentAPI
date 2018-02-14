using Legendary_Student_API.Models;
using Legendary_Student_API.Models.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Legendary_Student_API.Controllers
{
    [RoutePrefix("api/Dashboard")]
    public class DashboardController : ApiController
    {
        [Route("GetDashboardDetails/{User}")]
        [AcceptVerbs("GET", "POST", "PUT", "DELETE")]
        public IHttpActionResult GetDashboardDetails(string User)
        {
            return Ok(new Dashboard());
        }

        [Route("GetAllStudents/{User}")]
        [AcceptVerbs("GET", "POST", "PUT", "DELETE")]
        public IHttpActionResult GetAllStudents(string User)
        {
            //using (var db = new StudentContext())
            //{
            //    var blog = new Student()
            //    {
            //        CreatedDateTime = DateTime.Now,
            //        Email = "dfdfd@gmil.com",
            //        FatherName = "dfd",
            //        LastName = "dfdf",
            //        MobileNumber = "23232",
            //        Password = "dfdsdf",
            //        School = new School()
            //        {
            //            Address = new Address() { AddressValue = "sd", City = "sd", Country = "sd", PostalCode = "sd", State = "sd" },
            //            Code = "",
            //            CreatedDateTime = DateTime.Now,
            //            Email = "sda@gmail.com",
            //            MobileNumber = 2334,
            //            Name = "sda",
            //            Password = "dfdsdf"
            //        },
            //        Class = new Class() { ClassNumber = 2 },
            //        FirstName = "df",
            //        Address = new Address() { AddressValue = "sd", City = "sd", Country = "sd", PostalCode = "sd", State = "sd" }
            //    };
            //    db.Students.Add(blog);
            //    db.SaveChanges();
            //}
            return Ok(new List<Student>());
        }

        [Route("GetAllSchools/{User}")]
        [AcceptVerbs("GET", "POST", "PUT", "DELETE")]
        public IHttpActionResult GetAllSchools(string User)
        {
            return Ok(new List<School>());
        }

        [Route("NewExamDetails/{User}")]
        [AcceptVerbs("GET", "POST", "PUT", "DELETE")]
        public IHttpActionResult NewExamDetails(string User)
        {
            return Ok(new TestModel());
        }
    }
}