using Microsoft.AspNetCore.Mvc;
using MultivendorEcommerce.Interface;

namespace MultivendorEcommerce.Controllers
{
    [ApiController]
    public class VendorController : ControllerBase
    {
        private readonly IVendorRepository vendorRepository;

        public VendorController(IVendorRepository vendorRepository)
        {
            this.vendorRepository = vendorRepository;
        }

        [HttpGet]
        [Route("api/v1/Vendor/Popular")]
        public IActionResult GetPopularVendor()
        {
            var popularvendor = vendorRepository.GetPopularVendors();
            return Ok(popularvendor);
        }

        [HttpGet]
        [Route("api/v1/Vendor/Recommended")]
        public IActionResult GetRecommendedVendor()
        {
            var recommendedvendor = vendorRepository.GetRecommendedVendor();
            return Ok(recommendedvendor);
        }
    }
}
