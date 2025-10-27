using System.ComponentModel.DataAnnotations;

namespace ST10434337_POE.Models.ViewModels
{
    public class CreateClaim_VM
    {
        [Display(Name = "Claim Title")]
        [Required(ErrorMessage = "A Title is required")]
        public string Title { get; set; }

        [Display(Name = "Hours Worked")]
        [Required(ErrorMessage = "An amount of hours worked is required")]
        public TimeSpan HoursWorked { get; set; }
        /*
        <input asp-for="HoursWorked" type="time" class="form-control" step="1" />
        Step 1 = H:M:S 
        
         */

        [Display(Name = "Rate of Pay (Rands)")]
        [Required(ErrorMessage = "A rate of pay is required")]
        public decimal RatePerHour { get; set; }
        /*
         later do,
        Calc Total:
         public decimal TotalPay => HourlyRate * (decimal)HoursWorked.TotalHours;

         */

        [Display(Name = "Notes")]
        public string? SubmissionNote { get; set; }

        

    }
}
