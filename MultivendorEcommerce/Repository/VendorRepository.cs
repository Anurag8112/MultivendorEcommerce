using MultivendorEcommerce.DAL.Dbmodels;
using MultivendorEcommerce.DAL.Responsemodel;
using MultivendorEcommerce.Interface;
using System.Collections.Generic;
using System.Linq;

namespace MultivendorEcommerce.Repository
{
    public class VendorRepository : IVendorRepository
    {
        public PopularVendor GetPopularVendors()
        {
               
            PopularVendor popularVendors = new PopularVendor();
            List<Vendor> VendorList =new List<Vendor>();
            HomealignContext context = new HomealignContext();
            var vendors= context.VendorDetails.Where(x=>x.TypeId == 1).ToList();

            popularVendors.TotalSize = vendors.Count;
            popularVendors.TypeId = 1;

            foreach (var v in vendors)
            {
                Vendor vendor = new Vendor();
                vendor.Id = v.Id;
                vendor.Name = v.Name;
                vendor.Description = v.Description;
                vendor.Price = v.Price;
                vendor.stars = v.Stars;
                vendor.image = v.Img;
                vendor.CreatedOn = v.CreatedOn;
                VendorList.Add(vendor);
            }
            popularVendors.VendorList = VendorList;

            return popularVendors;
        }
    }
}
