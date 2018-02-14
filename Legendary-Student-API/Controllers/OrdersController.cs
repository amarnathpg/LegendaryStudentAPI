using Legendary_Student_API.Filters;
using Legendary_Student_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Legendary_Student_API.Controllers
{
    [RoutePrefix("api/Orders")]
    public class OrdersController : ApiController
    {
        [Route("")]
        [AcceptVerbs("GET", "POST")]
        public IHttpActionResult Get()
        {
            return Ok(Order.CreateOrders());
        }
    }
}