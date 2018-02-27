using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Legendary_Student_API.Models.Test
{
    [Table("tblQuestions")]
    public class Question
    {
        public Question()
        {
            Options = new HashSet<Option>();
        }

        [Key]
        public int QuestionID { get; set; }
        public int ConceptID { get; set; }
        public virtual Concept Concepts { get; set; }
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        [DataType(DataType.Text)]
        public string QuestionName { get; set; }
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        [DataType(DataType.Text)]
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Option> Options { get; set; }

    }
}