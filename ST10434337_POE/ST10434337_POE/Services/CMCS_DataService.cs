using ST10434337_POE.Models.DomainModels;

namespace ST10434337_POE.Services
{
    /// <summary>
    /// Used to instanciate in memory data of Domain Models/Tables
    /// </summary>
    public class CMCS_DataService 
    {
        private readonly List<Claim_DM> _Claims = new();
        private readonly List<User_DM> _Users = new();
        private readonly List<BankingDetails_DM> _Banking = new();

        public CMCS_DataService()
        {
            // AUTO INCREMENT in code 
            //https://learn.microsoft.com/en-us/answers/questions/984587/c-find-the-max-()-of-the-table-column-in-class-mod
            // Find the maximum ID by projecting the Id property
            int maxId = _Claims.Max(x => x.ClaimId);
            // Calculate the next ID
            int nextId = maxId + 1;

        }
    }
}
