namespace ST10434337_POE.Models.DomainModels
{
    public class BankingDetails_DM
    {
        public int BankingDetailsId { get; set; }
        public int UserId { get; set; }
        public string BankName { get; set; }
        public string BankBranch { get; set; }
        public string AccountNumber { get; set; }
    }
}
