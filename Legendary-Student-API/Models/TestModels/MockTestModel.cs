﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Legendary_Student_API.Models.TestModels
{
    public class MockTestModel:TestModel
    {
        public MockTestModel()
        {
            Question = new Dictionary<int, QuestionPairModel>();
        }
    }
}