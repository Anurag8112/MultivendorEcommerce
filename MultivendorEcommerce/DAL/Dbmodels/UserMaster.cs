using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MultivendorEcommerce.DAL.Dbmodels
{
    public class UserMaster
    {
        [Column("Id")]
        public Guid Id { get; set; }
        [Column("UserName")]
        public string UserName { get; set; }
        [Column("FirstName")]
        public string FirstName { get; set; }
        [Column("LastName")]
        public string LastName { get; set; }
        [Column("Password")]
        public string Password { get; set; }
        [Column("Email")]
        public string Email { get; set; }
        [Column("PhoneNumber")]
        public string PhoneNumber { get; set; }
        [Column("GenderId")]
        public int GenderId { get; set; }
        [Column("IsPolicyAccepted")]
        public bool IsPolicyAccepted { get; set; }
        [Column("IsVerified")]
        public bool IsVerified { get; set; }
        [Column("IsActive")]
        public bool IsActive { get; set; }
        [Column("CreatedOn")]
        public DateTime CreatedOn { get; set; }
        [Column("LastModifiedOn")]
        public DateTime LastModifiedOn { get; set;}

        public virtual Gender Gender { get; set; }
    }
}
