using System.ComponentModel.DataAnnotations;

namespace ST10434337_POE.Models.ViewModels
{
    // PC, AM take action
    public class ViewToVerifyClaims_VM
    {
        [Display(Name = "Claim Title")]
        public string Title { get; set; }

        [Display(Name = "Programme")]
        public string ProgrammeCode { get; set; }

        [Display(Name = "Hours Worked")]
        public string HourWorkedClaim { get; set; }

        [Display(Name = "Rate per Hour")]
        public string RatePerHourClaim { get; set; }

        [Display(Name = "Status")]
        public int Status { get; set; }

        [Display(Name = "Created on")]
        public DateTime CreatedDate { get; set; }


        /* Actions 
         Verify - Status = 2
         Reject - Status = 4
         Details - Open Selected Claim's Details
         
         */
    }
}
