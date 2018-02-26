using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Legendary_Student_API.Models
{
    [Table("tblSchoolClassMappings")]
    public class SchoolClassMapping
    {
        [Key]
        public int ID { get; set; }
        public int SchoolID { get; set; }
        public virtual School School { get; set; }
        public int ClassID { get; set; }
        public virtual Class Class { get; set; }
    }
}