using System;
using System.Collections.Generic;

#nullable disable

namespace MultivendorEcommerce.DAL.Dbmodels
{
    public partial class VendorType
    {
        public VendorType()
        {
            VendorDetails = new HashSet<VendorDetail>();
        }

        public int Id { get; set; }
        public string ProductType { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual ICollection<VendorDetail> VendorDetails { get; set; }
    }
}
