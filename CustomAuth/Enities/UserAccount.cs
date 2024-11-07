using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CustomAuth.Enities
{
    [Index(nameof(Email), IsUnique = true)]
    [Index(nameof(UserName), IsUnique = true)]
    public class UserAccount
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Fist Name is Required.")]
        [MaxLength(50, ErrorMessage ="Max 50 Charaters allowed.")]
        public string FistName { get; set; }

        [Required(ErrorMessage ="Last Name is Required.")]
        [MaxLength(50, ErrorMessage = "Max 50 Charaters allowed.")]

        public string LastName { get; set; }

        [Required(ErrorMessage ="Email is Required.")]
        [MaxLength(100, ErrorMessage = "Max 100 Charaters allowed.")]

        public string Email { get; set; }

        [Required(ErrorMessage ="UserName is Required.")]
        [MaxLength(20, ErrorMessage = "Max 20 Charaters allowed.")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Password is Required.")]
        [MaxLength(20, ErrorMessage = "Max 20 Charaters allowed.")]
        public string Password { get; set; }

    }
}
