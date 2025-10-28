using System.ComponentModel.DataAnnotations;

namespace ST10434337_POE.Models.DomainModels
{
    /// <summary>
    /// [Key] Auto increments 
    /// Code used as kind of pk
    /// </summary>
    public class Programmes_DM
    {
        [Key]
        public int ProgrammeId { get; set; }

        [Required, StringLength(8)]
        public string ProgrammeCode { get; set; }

        [Required, StringLength(200)]
        public string ProgrammeName { get; set; }

        // Navigation Property
        public ICollection<Claim_DM> Claims { get; set; } = new List<Claim_DM>();

    }
}
