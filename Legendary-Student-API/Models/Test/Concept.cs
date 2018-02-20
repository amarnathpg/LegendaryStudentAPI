using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Legendary_Student_API.Models.Test
{
    [Table("tblConcept")]
    public class Concept
    {
        [Key]
        public int ConceptID { get; set; }

        public int SubjectID { get; set; }
        public virtual Subject Subject { get; set; }

        public string ConceptName { get; set; }
        public string Description { get; set; }

        public ICollection<Question> Questions { get; set; }
    }
}