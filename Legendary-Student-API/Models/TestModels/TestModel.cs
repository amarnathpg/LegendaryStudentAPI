using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Legendary_Student_API.Models.TestModels
{
    public class TestModel
    {

        public int SchoolID { get; set; }
        public int Class { get; set; }

        public string TestID { get; set; }
        public string TestCode { get; set; }
        public string TestName { get; set; }
        public TestType TestCategory { get; set; }
        public int TestQuestionsCount { get; set; }
        public int EachQuestionWeightage { get; set; }
        public int TestTotalMarks { get; set; }

        public Dictionary<int, QuestionPairModel> Question { get; set; }
        public DateTime TestDate { get; set; }
    }
    public enum TestType
    {
        MockTest,
        OnlineTest
    }
}