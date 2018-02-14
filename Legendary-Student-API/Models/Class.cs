using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Legendary_Student_API.Models
{
    [Table("tblClassMaster")]
    public class Class
    {
        public int ID { get; set; }
        public int ClassNumber { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}