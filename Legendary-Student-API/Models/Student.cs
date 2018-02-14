using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Data.SqlTypes;

namespace Legendary_Student_API.Models
{
    [Table("tblStudentMaster")]
    public class Student
    {
        [Key]
        [Column(Order = 1)]
        public int ID { get; set; }

        [Required]
        [ConcurrencyCheck]
        [Column("FirstName", Order = 2)]
        public string FirstName { get; set; }

        [Required]
        [ConcurrencyCheck]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string FatherName { get; set; }

        [Required]
        public string MobileNumber { get; set; }

        [Required]
        [ForeignKey("Address")]
        [Column(Order = 3)]
        public int AddressID { get; set; }
        public virtual Address Address { get; set; }

        [Required]
        [ForeignKey("Class")]
        [Column(Order=4)]
        public int ClassID { get; set; }
        public Class Class { get; set; }

        [Required]
        [ForeignKey("School")]
        public int SchoolID { get; set; }
        public School School { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public DateTime CreatedDateTime { get; set; }
    }
}