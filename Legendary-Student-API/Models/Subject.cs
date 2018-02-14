using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Legendary_Student_API.Models
{
    [Table("tblSubjectMaster")]
    public class Subject
    {
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public string Description { get; set; }
    }
}