﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Legendary_Student_API.Models.Test
{
    [Table("tblAnswers")]
    public class Answer
    {
        [Key]
        public int AnswerID { get; set; }
        public int QuestionID { get; set; }
        [Key]
        public int OptionID { get; set; }
        public virtual Option Option { get; set; }
        public string OptionCode { get; set; }
        public string AnswerDescription { get; set; }
    }
}