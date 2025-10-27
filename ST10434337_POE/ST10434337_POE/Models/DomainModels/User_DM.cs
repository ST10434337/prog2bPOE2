using System.ComponentModel.DataAnnotations;

namespace ST10434337_POE.Models.DomainModels
{
    public class User_DM
    {
        [Key]
        public int UserId { get; set; }// GUID
        public string Name { get; set; }
        public string? Surname { get; set; }
        [EmailAddress, MaxLength(500)]
        public string Email { get; set; }
        public int Roll { get; set; } // 1 Academic Manager, 2 Programme Coordinator, 3 HR, 4 Lecturer
        public string Username { get; set; }
        public string PasswordHash { get; set; } // Lookup if hashes match to sign in 

        //Navigtaion props...?
        public ICollection<Claim_DM> UserClaims { get; set; } = new List<Claim_DM>();


    }
}
