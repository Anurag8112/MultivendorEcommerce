using MultivendorEcommerce.DAL.Responsemodel;

namespace MultivendorEcommerce.Interface
{
    public interface IVendorRepository
    {
        public PopularVendor GetPopularVendors();
        public RecommendedVendor GetRecommendedVendor();
    }
}
