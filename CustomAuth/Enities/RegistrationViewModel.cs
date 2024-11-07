using System.ComponentModel.DataAnnotations;

namespace CustomAuth.Enities
{
    public class RegistrationViewModel
    {
        [Required(ErrorMessage = "Fist Name is Required.")]
        [MaxLength(50, ErrorMessage = "Max 50 Charaters allowed.")]
        public string FistName { get; set; }

        [Required(ErrorMessage = "Last Name is Required.")]
        [MaxLength(50, ErrorMessage = "Max 50 Charaters allowed.")]

        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is Required.")]
        [MaxLength(100, ErrorMessage = "Max 100 Charaters allowed.")]
        //[EmailAddress ()]
        [RegularExpression(@"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,7}\b", ErrorMessage = "Plese Enter Your Email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "UserName is Required.")]
        [MaxLength(20, ErrorMessage = "Max 20 Charaters allowed.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is Required.")]
        [StringLength(20, MinimumLength =5 , ErrorMessage = "Max 20 or min 5 Charaters allowed.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Confirm You Password.")]
        [DataType(DataType.Password)]
        public string Confirmpassword { get; set; }
    }
}
