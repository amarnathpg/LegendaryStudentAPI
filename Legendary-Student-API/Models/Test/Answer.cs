using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Legendary_Student_API.Models.Test
{
    public class Answer
    {
        public int ID { get; set; }
        public int AnswerID { get; set; }
        public int QuestionID { get; set; }
        public string AnswerDescription { get; set; }
    }
}