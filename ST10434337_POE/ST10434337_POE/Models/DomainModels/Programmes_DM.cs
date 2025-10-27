namespace ST10434337_POE.Models.DomainModels
{
    public class Programmes_DM
    {
        public string ProgrammeCode { get; set; } //PK
        public string ProgrammeName { get; set; }
        
        // Programmes_DM can be selectd by a claim, zero to many claims can be related to a Programme_DM code.

    }
}
