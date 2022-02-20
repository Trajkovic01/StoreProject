using System.ComponentModel.DataAnnotations;

namespace Inlämnmingsuppgift_ASP.Models.ViewModels
{
    public class SignInModels
    {
        [Required(ErrorMessage = "Email cant be empty")]
        [Display(Name = "Email")]
        [StringLength(100, ErrorMessage = "Email needs to be valid", MinimumLength = 6)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password cant be empty")]
        [Display(Name = "Password")]
        [StringLength(100, ErrorMessage = "Email needs to be valid", MinimumLength = 8)]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}
