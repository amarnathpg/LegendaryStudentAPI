using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Legendary_Student_API.Models.Test
{
    public class OnlineTest:TestModel
    {
        public OnlineTest()
        {
            Question = new Dictionary<int, Questions>();
        }
    }
}