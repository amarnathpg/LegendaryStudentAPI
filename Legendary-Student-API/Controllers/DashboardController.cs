using Legendary_Student_API.Models;
using Legendary_Student_API.Models.TestModels;
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
        [Route("GetDashboardDetails")]
        [AcceptVerbs("GET", "POST", "PUT", "DELETE")]
        public IHttpActionResult GetDashboardDetails(string User)
        {
            return Ok(new DashboardModel());
        }

        [Route("GetAllStudents")]
        [AcceptVerbs("GET", "POST", "PUT", "DELETE")]
        public IHttpActionResult GetAllStudents(string User)
        {
            return Ok(new List<StudentRegistrationModel>());
        }

        [Route("GetAllSchools")]
        [AcceptVerbs("GET", "POST", "PUT", "DELETE")]
        public IHttpActionResult GetAllSchools(string User)
        {
            return Ok(new List<SchoolRegistrationModel>());
        }

        [Route("NewExamDetails")]
        [AcceptVerbs("GET", "POST", "PUT", "DELETE")]
        public IHttpActionResult NewExamDetails(string User)
        {
            return Ok(new NewTestModel());
        }
    }
}