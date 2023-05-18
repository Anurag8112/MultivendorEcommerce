using System.ComponentModel.DataAnnotations;

namespace MultivendorEcommerce.DAL.RequestModel
{
    public class UserLogin
    {
        [Required(ErrorMessage ="Email Is Required")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Password Is Required")]
        public string Password { get; set; }
    }
}
