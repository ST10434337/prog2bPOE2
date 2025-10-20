using System.ComponentModel.DataAnnotations;

namespace ST10434337_POE.Models.DomainModels
{
    public class User_DM
    {
        public int UserId { get; set; }// use GUID?
        [Required]
        public string Name { get; set; }
        public string? Surname { get; set; }
        [Required]
        [EmailAddress, MaxLength(500)]
        public string Email { get; set; }
        [Required]
        public UserType Roll { get; set; }



    }
}
