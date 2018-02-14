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
        [Key]
        [Column(Order = 1)]
        public int ID { get; set; }

        [Required]
        [ConcurrencyCheck]
        [Column("Name", Order = 2)]
        public string Name { get; set; }
        
        public string Code { get; set; }

        [Required]
        public int MobileNumber { get; set; }

        [Required]
        [ForeignKey("Address")]
        [Column(Order = 3)]
        public int AddressID { get; set; }
        public virtual Address Address { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public DateTime CreatedDateTime { get; set; }

        public ICollection<Class> Class { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

    }
}