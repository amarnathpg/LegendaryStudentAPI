using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Legendary_Student_API.Models.TestModels
{
    public class QuestionPairModel
    {
        public QuestionPairModel()
        {
            Options = new Dictionary<int, string>();
        }
        public string Question { get; set; }
        public Dictionary<int, string> Options { get; set; }
        public int Answer { get; set; }
    }
}