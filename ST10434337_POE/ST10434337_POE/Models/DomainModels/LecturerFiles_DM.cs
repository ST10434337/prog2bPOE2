using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ST10434337_POE.Models.DomainModels
{
    /// <summary>
    /// [Key] Auto increment
    /// [FK] 
    /// </summary>
    public class LecturerFiles_DM
    {
        [Key]
        public int LecFileId { get; set; }

        [ForeignKey("Claim")]
        public int ClaimId { get; set; }

        [Required, StringLength(255)]
        public string FileName { get; set; }

        [StringLength(20)]
        public string? FileExtention { get; set; }

        public int FileSize { get; set; }

        [StringLength(500)]
        public string? FilePath { get; set; }

        // Navigation Property
        public Claim_DM Claim { get; set; }

    }
}
