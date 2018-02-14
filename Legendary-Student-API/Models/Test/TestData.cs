using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Legendary_Student_API.Models.Test
{
    public class TestData
    {
        public int TestID { get; set; }
        public int QuestionID { get; set; }
        public int AnswerID { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
    }
}