using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Legendary_Student_API.Models.TestModels
{
    public class OnlineTestModel:TestModel
    {
        public OnlineTestModel()
        {
            Question = new Dictionary<int, QuestionPairModel>();
        }
    }
}