using Legendary_Student_API.Models.TestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Legendary_Student_API.Controllers
{
    [RoutePrefix("api/Test")]
    public class TestController : ApiController
    {
        [Route("GetExamDetails/{User}/{Type}")]
        public IHttpActionResult GetExamDetails([FromUri]string User, [FromUri]TestType Type)
        {
            if (Type == TestType.MockTest)
                return Ok(new MockTestModel());
            else
                return Ok(new OnlineTestModel());
        }

        [Route("PostExamData/{User}")]
        public IHttpActionResult PostExamData([FromUri]string User, [FromBody]List<TestData> data)
        {
            return Ok(new ResultData());
        }

    }
}