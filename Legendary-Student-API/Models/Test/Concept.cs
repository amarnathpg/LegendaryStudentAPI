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
        public Concept()
        {
            Questions = new HashSet<Question>();
        }
        [Key]
        public int ConceptID { get; set; }

        public int SubjectID { get; set; }
        public virtual Subject Subject { get; set; }
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        [DataType(DataType.Text)]
        public string ConceptName { get; set; }
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        [DataType(DataType.Text)]
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}