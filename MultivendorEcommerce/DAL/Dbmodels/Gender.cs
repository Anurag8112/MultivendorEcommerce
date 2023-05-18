using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MultivendorEcommerce.DAL.Dbmodels
{
    public class Gender
    {
        public Gender()
        {
            UserMaster = new HashSet<UserMaster>();
        }

        [Column("Id")]
        public int Id { get; set; }
        [Column("GenderName")]
        public string GenderName { get; set; }
        [Column("CreatedOn")]
        public DateTime CreatedOn { get; set; }
        [Column("LastModifiedOn")]
        public DateTime LastModifiedOn { get; set; }

        public virtual ICollection<UserMaster> UserMaster { get; set; }
    }
}
