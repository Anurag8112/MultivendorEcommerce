using MultivendorEcommerce.DAL.Responsemodel;
using System.Collections.Generic;

namespace MultivendorEcommerce.Interface
{
    public interface IVendorRepository
    {
        public PopularVendor GetPopularVendors();
    }
}
