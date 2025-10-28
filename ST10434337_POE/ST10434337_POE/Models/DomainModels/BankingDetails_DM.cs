using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ST10434337_POE.Models.DomainModels
{
    /// <summary>
    /// [Key] auto increment
    /// </summary>
    public class BankingDetails_DM
    {
        [Key]
        public int BankingDetailsId { get; set; } 

        [ForeignKey("User")]
        public int UserId { get; set; } 

        [Required, StringLength(100)]
        public string BankName { get; set; } = "No Bank Name";

        [Required, StringLength(100)]
        public string BankBranch { get; set; } = "No Branch Name";

        [Required, StringLength(50)]
        public string AccountNumber { get; set; } = "No Account Number";

        // Navigation Property
        public User_DM User { get; set; } // Each BankingDetails belongs to 1 User
    }
}
