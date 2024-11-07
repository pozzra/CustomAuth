using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CustomAuth.Enities
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "UserName or Email is Required.")]
        [MaxLength(20, ErrorMessage = "Max 20 Charaters allowed.")]
        [DisplayName("UserName or Email")]
        public string UserNameOrEmail { get; set; }

        [Required(ErrorMessage = "Password is Required.")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Max 20 or min 5 Charaters allowed.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
