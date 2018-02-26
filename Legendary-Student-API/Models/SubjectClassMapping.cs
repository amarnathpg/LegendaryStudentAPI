using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Legendary_Student_API.Models
{
    [Table("tblSubjectClassMapping")]
    public class SubjectClassMapping
    {
        [Key]
        public int ID { get; set; }
        public int SubjectID { get; set; }
        public virtual Subject Subject { get; set; }
        public int ClassID { get; set; }
        public virtual Class Class { get; set; }
    }
}