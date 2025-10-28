using System.ComponentModel.DataAnnotations;

namespace ST10434337_POE.Models.DomainModels
{
    /// <summary>
    /// Roll-> 1 Academic Manager, 2 Programme Coordinator, 3 HR, 4 Lecturer
    /* 
        PwHash Get pw, create hash then compare
    */
    /// </summary>
    public class User_DM
    {
        [Key]
        public int UserId { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string? Surname { get; set; }

        [Required, EmailAddress, StringLength(255)]
        public string Email { get; set; }

        [Required, Range(1, 4)]
        public int Roll { get; set; }

        [Required, StringLength(50)]
        public string Username { get; set; }

        [Required]
        public string PasswordHash { get; set; }


        // Navigation Properties
        public ICollection<Claim_DM> Claims { get; set; } = new List<Claim_DM>();
        public BankingDetails_DM? BankingDetails { get; set; } 


    }
}
