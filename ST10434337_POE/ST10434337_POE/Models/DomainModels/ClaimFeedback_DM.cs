namespace ST10434337_POE.Models.DomainModels
{
    public class ClaimFeedback_DM
    {
        public int ClaimFeedbackID { get; set; }
        public int ClaimID { get; set; }
        public int ClaimStatus { get; set; }// int represents stage 1 pending, 2 verified, 3 approved, 4 rejected
        public string? VerifiedBy { get; set; }
        public DateTime VerifiedDate { get; set; }
        public string? ApprovedBy { get; set; }
        public DateTime ApprovedDate { get; set; }
        public string? RejectedBy { get; set; }
        public DateTime RejectedDate { get; set; }

    }
}
