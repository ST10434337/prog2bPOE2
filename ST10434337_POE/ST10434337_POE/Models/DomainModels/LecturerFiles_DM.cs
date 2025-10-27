namespace ST10434337_POE.Models.DomainModels
{
    public class LecturerFiles_DM
    {
        // Primary Key
        public int LecFileId { get; set; }
        
        // For Which claim  (FK)
        public int ClaimId { get; set; }

        // File Details
        public required string FileName { get; set; }
        public string? FileExtention { get; set; }
        public int FileSize { get; set; }

        public string? FilePath { get; set; }

        // Each LecturerFiles_DM has only 1 Claim_DM but a Claim_DM can have zero or many LecturerFiles_DM
    }
}
