using System.ComponentModel.DataAnnotations;

namespace Spedito.Models.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email is required")]
        [MaxLength(50, ErrorMessage = "The email can be a maximum of 50 characters")]
        [EmailAddress(ErrorMessage = "Enter the correct email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MaxLength(50, ErrorMessage = "The password can be a maximum of 50 characters")]
        [MinLength(6, ErrorMessage = "The password can be a maximum of 6 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
