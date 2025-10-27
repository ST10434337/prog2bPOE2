using System.ComponentModel.DataAnnotations;

namespace ST10434337_POE.Models.DomainModels
{
    public class Claim_DM
    {
        // Claim Details
        public int ClaimId { get; set; } //PK
        public required string ClaimTitle { get; set; }
        public TimeSpan HoursWorked { get; set; }
        public decimal RatePerHour { get; set; }
        public string? SubmissionNote { get; set; }

        // For what specific Programme
        public int ProgrammeCode { get; set; } // FK
        // Lookup a programme by Code
        // A Claim_Dm selects a Programme_DM, only one ProgrammeCode can be selected by a Claim_DM

        // Who made claim (User)
        public int UserId { get; set; } // FK
        // Every Claim_DM is assigned to one User_DM, a User_DM can have zero or many claims

        // Related File Names 
        public List<LecturerFiles_DM>? Files { get; set; } = new List<LecturerFiles_DM>();

        //Claim Stats
        public int ClaimStatus { get; set; } = 1; // On Creation default to pending 
                                                  // int represents stage 1 pending, 2 verified, 3 approved, 4 rejected

        // Navigation Properties? 
        public Programmes_DM Programme { get; set; }
        public User_DM User { get; set; }



    }
}
