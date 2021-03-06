﻿using System;
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
        public Class()
        {
            this.Schools = new HashSet<School>();
        }
        public int ClassID { get; set; }

        [Range(typeof(Int32),"1","12")]
        public int ClassNumber { get; set; }

        public virtual ICollection<School> Schools { get; set; }
    }
}