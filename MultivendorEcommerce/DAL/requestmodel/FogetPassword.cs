using System.ComponentModel.DataAnnotations;

namespace MultivendorEcommerce.DAL.RequestModel
{
    public class FogetPassword
    {
        [Required]
        public string Email { get; set; }
    }
}
