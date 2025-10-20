namespace ST10434337_POE.Models.DomainModels
{
    public class Claim_DM
    {
        public int ClaimId { get; set; }
        public string ClaimTitle { get; set; }
        public int HoursWorked { get; set; }
        public int ForProggrammeId { get; set; }
        public string SubmissionNote { get; set; }
        public int UserId { get; set; }
        public int ProgrammeId { get; set; }
        public int RatePerHour { get; set; }
    }
}
