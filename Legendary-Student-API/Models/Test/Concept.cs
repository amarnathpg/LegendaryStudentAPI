using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Legendary_Student_API.Models.Test
{
    public class Concept
    {
        public int ConceptID { get; set; }
        public int Class { get; set; }
        public int SubjectID { get; set; }
        public string Description { get; set; }
    }
}