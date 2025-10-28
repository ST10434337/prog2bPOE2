using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ST10434337_POE.Models.DomainModels
{
    /// <summary>
    /// [Key] Auto increments 
    /// ClaimStatus is default to pending
    /// SubmissionNote-> Lec comments 
    /// ProcessNotes-> internally for staff
    /// ClaimFeedback-> attached to claim for Lecturer
    /*
         Banking Dertails Decoupled, lookup banking details by userid, 
        stored in Banking details 
    */
    /// </summary>
    public class Claim_DM
    {
        // Claim Details
        [Key]
        public int ClaimId { get; set; }

        [Required, StringLength(150)]
        public required string ClaimTitle { get; set; }

        [Required]
        public TimeSpan HoursWorked { get; set; }

        [Required, Range(0.01, 10000)]
        public decimal RatePerHour { get; set; }

        [StringLength(500)]
        public string? SubmissionNote { get; set; }

        [Range(1, 4)]
        public int ClaimStatus { get; set; } = 1; // 1=Pending, 2=Verified, 3=Approved, 4=Rejected

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;

        // For Staff, any comments on claim Intenally
        [StringLength(500)]
        public string? ProcessNotes { get; set; }
        // Comments By PC, AM or HR to Lec about claim
        [StringLength(500)]
        public string? ClaimFeedback { get; set; }

        [ForeignKey("Programme")]
        public int ProgrammeId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        // Navigation Properties
        public Programmes_DM Programme { get; set; }
        public User_DM User { get; set; }
        public ICollection<LecturerFiles_DM> Files { get; set; } = new List<LecturerFiles_DM>();

        


    }
}
