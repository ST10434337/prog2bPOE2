using System.ComponentModel.DataAnnotations;

namespace ST10434337_POE.Models.ViewModels
{
    public class Login_VM
    {
        [Required(ErrorMessage = "Please enter your username.")]
        [Display(Name = "Username")]
        [StringLength(50, ErrorMessage = "Username must be under 50 characters.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter your password.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
