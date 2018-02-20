using Legendary_Student_API.Models.Test;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Legendary_Student_API.Models
{
    [Table("tblSubject")]
    public class Subject
    {
        public Subject() {
            this.Students = new HashSet<Student>();
            this.Concepts = new HashSet<Concept>();
        }
        [Key]
        public int SubjectID { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public string Description { get; set; }

        public ICollection<Concept> Concepts { get; set; }
        public ICollection<Student> Students { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}