using System.ComponentModel.DataAnnotations;

namespace Inlämnmingsuppgift_ASP.Models.ViewModels
{
    public class SignUpModels
    {
        [Required(ErrorMessage = "Name cant be empty")]
        [Display(Name = "Name")]
        [StringLength(100, ErrorMessage = "Name can be minimum of 2 letters", MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName cant be empty")]
        [Display(Name = "LastName")]
        [StringLength(100, ErrorMessage = "LastName can be minimum of 2 letters", MinimumLength = 2)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email cant be empty")]
        [Display(Name = "Email")]
        [StringLength(100, ErrorMessage = "Email needs to be valid", MinimumLength = 6)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password cant be empty")]
        [Display(Name = "Password")]
        [StringLength(100, ErrorMessage = "Password can be minimum of 2 letters", MinimumLength = 2)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password cant be empty")]
        [Display(Name = "Confirm Password")]
        [Compare(nameof(Password), ErrorMessage = "Dont match")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "StreetName cant be empty")]
        [Display(Name = "StreetName")]
        [StringLength(100, ErrorMessage = "StreetName can be minimum of 2 letters", MinimumLength = 2)]
        public string StreetName { get; set; }

        [Required(ErrorMessage = "PostalCode cant be empty")]
        [Display(Name = "PostalCode")]
        [StringLength(5, ErrorMessage = "PostalCode needs to be 5 letters", MinimumLength = 5)]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "City cant be empty")]
        [Display(Name = "City")]
        [StringLength(100, ErrorMessage = "City can be minimum of 2 letters", MinimumLength = 2)]
        public string City { get; set; }
    }
}
