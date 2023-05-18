using System.ComponentModel.DataAnnotations;

namespace MultivendorEcommerce.DAL.RequestModel
{
    public class UserSignup
    {
        [Required(ErrorMessage ="UserName Is Required")]
        public string  UserName { get; set; }

        [Required(ErrorMessage = "FirstName Is Required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName Is Required")] 
        public string LastName { get; set; }

        [Required(ErrorMessage = "Password Is Required")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Email Is Required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "PhoneNumber Is Required")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Gender Is Required")]
        public int GenderId { get; set; }

        [Required(ErrorMessage = "IsPolicyAccepted Is Required")]
        public bool IsPolicyAccepted { get; set; }
    }
}
