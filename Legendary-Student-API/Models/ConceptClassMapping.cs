﻿using Legendary_Student_API.Models.Test;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Legendary_Student_API.Models
{
    [Table("tblConceptClassMapping")]
    public class ConceptClassMapping
    {
        [Key]
        public int ID { get; set; }
        public int ConceptID { get; set; }
        public virtual Concept Concept { get; set; }
        public int ClassID { get; set; }
        public virtual Class Class { get; set; }
    }
}