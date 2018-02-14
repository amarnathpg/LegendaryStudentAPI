using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Legendary_Student_API.Models
{
    public class ForgotPassword
    {
        [Required]
        public string Email { get; set; }
    }
}