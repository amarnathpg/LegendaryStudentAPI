using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Legendary_Student_API.Models.Test
{
    [Table("tblOptions")]
    public class Option
    {
        [Key]
        public int OptionID { get; set; }

        public int QuestionID { get; set; }
        public virtual Question Question { get; set; }
        public string OptionName { get; set; }
        public string Description { get; set; }

        public bool IsAnswer { get; set; }
    }
}