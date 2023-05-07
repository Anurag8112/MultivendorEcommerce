using System;
using System.Collections.Generic;

namespace MultivendorEcommerce.DAL.Responsemodel
{

    public class RecommendedVendor
    {
        public int TotalSize { get; set; }
        public int TypeId { get; set; }
        public List<RVendor> VendorList { get; set; }
    }

    public class RVendor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int stars { get; set; }
        public string image { get; set; }
        public DateTime CreatedOn { get; set; }
    }

}
