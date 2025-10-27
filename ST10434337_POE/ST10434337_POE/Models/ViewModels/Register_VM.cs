using System.ComponentModel.DataAnnotations;

namespace ST10434337_POE.Models.ViewModels
{
    public class Register_VM
    {
        [Required(ErrorMessage = "Please enter your first name.")]
        [Display(Name = "First Name")]
        [StringLength(50, ErrorMessage = "First name must be under 50 characters.")]
        public string Name { get; set; }

        [Display(Name = "Surname")]
        [StringLength(50, ErrorMessage = "Surname must be under 50 characters.")]
        public string? Surname { get; set; }

        [Required(ErrorMessage = "Please enter a valid email address.")]
        [EmailAddress(ErrorMessage = "Email format is not valid.")]
        [StringLength(100, ErrorMessage = "Email address must be under 100 characters.")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a username.")]
        [StringLength(50, ErrorMessage = "Username must be under 50 characters.")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter a password.")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long.")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please select your user role.")]
        [Range(1, 4, ErrorMessage = "Invalid role selection.")]
        [Display(Name = "User Role")]
        public int Roll { get; set; }
    }
}
