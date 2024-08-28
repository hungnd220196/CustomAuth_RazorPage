using System.ComponentModel.DataAnnotations;

namespace CustomAuth.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "FirstName is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required")]

        public string Email { get; set; }

        [Required(ErrorMessage = "UserName is required")]
        [MaxLength(20, ErrorMessage = "Max 20 character allowed")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Max 20 and min 5 characters allowed")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Please confirm your password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
