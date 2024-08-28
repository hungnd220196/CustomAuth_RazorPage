using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CustomAuth.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "UserNameOrEmail is required")]
        [MaxLength(20, ErrorMessage = "Max 20 character allowed")]
        [DisplayName("UserName Or Password")]
        public string UserNameOrEmail { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Max 20 and min 5 characters allowed")]
        public string Password { get; set; }
    }
}
