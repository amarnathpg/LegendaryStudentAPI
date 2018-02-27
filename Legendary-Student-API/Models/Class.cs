using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Legendary_Student_API.Models
{
    [Table("tblClassMaster")]
    public class Class
    {
        public int ClassID { get; set; }

        [Range(typeof(Int32),"1","12")]
        public int ClassNumber { get; set; }

        public int SchoolID { get; set; }
        public virtual School Schools { get; set; }
    }
}