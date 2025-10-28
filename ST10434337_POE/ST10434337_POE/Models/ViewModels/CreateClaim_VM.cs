using ST10434337_POE.Models.DomainModels;
using System.ComponentModel.DataAnnotations;

namespace ST10434337_POE.Models.ViewModels
{
    // Input Validation, Display
    public class CreateClaim_VM
    {
        [Key]
        public int ClaimId { get; set; }

        // Claim Details
        [Required(ErrorMessage = "Please enter a claim title.")]
        [StringLength(100, ErrorMessage = "Title must be under 100 characters.")]
        [Display(Name = "Claim Title")]
        public string ClaimTitle { get; set; }

        [Required(ErrorMessage = "Please enter hours worked.")]
        [Range(0, 300, ErrorMessage = "Hours worked must be between 0 and 300.")]
        [Display(Name = "Hours Worked")]
        public double HoursWorked { get; set; }

        [Required(ErrorMessage = "Please enter your rate per hour.")]
        [Range(0.01, 10000.00, ErrorMessage = "Rate must be between R0.01 and R10,000.")]
        [DataType(DataType.Currency)]
        [Display(Name = "Rate per Hour (R)")]
        public decimal RatePerHour { get; set; }

        [Display(Name = "Submission Note")]
        [StringLength(500, ErrorMessage = "Note must not exceed 500 characters.")]
        public string? SubmissionNote { get; set; }

        // FKs to other 
        [Required(ErrorMessage = "Please select a programme.")]
        [Display(Name = "Programme")]
        public string ProgrammeCode { get; set; }

        public List<Programmes_DM> Programmes{ get; set; } = new List<Programmes_DM>();

        [Required(ErrorMessage = "User is required.")]
        public int UserId { get; set; }

        // --- File Upload ---
        [Display(Name = "Upload Supporting Files (0 - 5)")]
        [MaxLength(5, ErrorMessage = "You can upload up to 5 files only.")]
        public List<IFormFile>? UploadedFiles { get; set; }



    }
}
