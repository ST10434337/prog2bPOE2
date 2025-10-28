using Microsoft.AspNetCore.Mvc;

namespace ST10434337_POE.Controllers
{
    // Verify, Approve, Reject 
    // All Claim Details w/ User Details (List of Documents)
    public class ManageClaimsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
