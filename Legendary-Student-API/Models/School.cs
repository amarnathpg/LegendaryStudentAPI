using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Legendary_Student_API.Models
{
    [Table("tblSchoolMaster")]
    public class School
    {
        public School()
        {
            this.Class = new HashSet<Class>();
        }
        [Key]
        [Column("SchoolID", Order = 1)]
        public int SchoolID { get; set; }

        [Required]
        [ConcurrencyCheck]
        [Column("Name", Order = 2)]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 4)]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Column("Code", Order = 3)]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 4)]
        [DataType(DataType.Text)]
        public string Code { get; set; }

        [Required]
        [Column("MobileNumber", Order = 4)]
        [DataType(DataType.PhoneNumber)]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 10)]
        public string MobileNumber { get; set; }

        [Required]
        //[ForeignKey("Address")]
        [Column("AddressID", Order = 5)]
        public int AddressID { get; set; }
        public virtual Address Address { get; set; }

        [Required]
        [Column("Email", Order = 6)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Column("Password", Order = 7)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Column("CreatedDateTime", Order = 8)]
        [DataType(DataType.DateTime)]
        public DateTime CreatedDateTime { get; set; }

        [Column("ModifiedDateTime", Order = 9)]
        [DataType(DataType.DateTime)]
        public DateTime ModifiedDateTime { get; set; }

        [Column("IsActive", Order = 10)]
        public bool IsActive { get; set; }

        [Column("RowVersion", Order = 11)]
        [Timestamp]
        public byte[] RowVersion { get; set; }

        public ICollection<Class> Class { get; set; }

    }
}