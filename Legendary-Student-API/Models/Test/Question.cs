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
        [Key]
        public int QuestionID { get; set; }
        public int SubjectID { get; set; }
        public virtual Subject Subject { get; set; }
        public string QuestionCode { get; set; }
        public string QuestionName { get; set; }
        public string QuestionDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Option> Options { get; set; }
        public virtual Answer Answer { get; set; }
    }
}