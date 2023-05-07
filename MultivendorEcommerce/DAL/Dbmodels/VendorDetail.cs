using System;
using System.Collections.Generic;

#nullable disable

namespace MultivendorEcommerce.DAL.Dbmodels
{
    public partial class VendorDetail
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Stars { get; set; }
        public string Img { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual VendorType Type { get; set; }
    }
}
