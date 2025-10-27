namespace ST10434337_POE.Models.DomainModels
{
    public class BankingDetails_DM
    {
        public int BankingDetailsId { get; set; }
        
        //Lec Banking Details
        public string? BankName { get; set; } = "No Bank Name";
        public string? BankBranch { get; set; } = "No Branch Name";
        public string? AccountNumber { get; set; } = "No Account Number";

        //Who
        public int UserId { get; set; }
        // Each BankingDetails_DM is related to a User_DM, User_DM has only 1 banking details
    }
}
