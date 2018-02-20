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
        public Student()
        {
            Subjects = new HashSet<Subject>();
        }

        [Key]
        [Column("StudentID", Order = 1,TypeName ="int")]
        public int StudentID { get; set; }

        [Required]
        [Column("SchoolID", Order = 2, TypeName = "int")]
        public int SchoolID { get; set; }

        [Required]
        [Column("ClassID", Order = 3, TypeName = "int")]
        public int ClassID { get; set; }
        public virtual Class Class { get; set; }

        [Required]
        [Column("Address", Order = 4)]
        public int AddressID { get; set; }
        public virtual Address Address { get; set; }

        [Required]
        [ConcurrencyCheck]
        [Column("FirstName", Order = 5)]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 4)]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required]
        [ConcurrencyCheck]
        [Column("LastName", Order = 6)]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 4)]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Required]
        [Column("FatherName", Order = 7)]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 4)]
        [DataType(DataType.Text)]
        public string FatherName { get; set; }

        [Required]
        [Column("MobileNumber", Order = 8)]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 10)]
        [DataType(DataType.PhoneNumber)]
        public string MobileNumber { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [Column("Email", Order = 9)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [Column("Password", Order = 10)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Column("CreatedDateTime", Order = 11)]
        [DataType(DataType.DateTime)]
        public DateTime CreatedDateTime { get; set; }

        [Column("ModifiedDateTime", Order = 12)]
        [DataType(DataType.DateTime)]
        public DateTime ModifiedDateTime { get; set; }

        [Column("IsActive", Order = 13)]
        public bool IsActive { get; set; }

        public ICollection<Subject> Subjects { get; set; }

        [Column("RowVersion", Order = 14)]
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}