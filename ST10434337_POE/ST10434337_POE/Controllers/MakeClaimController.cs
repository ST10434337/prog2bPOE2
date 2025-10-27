using Microsoft.AspNetCore.Mvc;
using ST10434337_POE.Models.ViewModels;

namespace ST10434337_POE.Controllers
{
    public class MakeClaimController : Controller
    {
        // List all 
        public IActionResult Index()
        {
            return View();
        }


        // Create 
        [HttpGet]
        public async Task<IActionResult> Create(CreateClaim_VM model, IFormFile file) 
        {
            return null;
        }
        // Create
        [HttpPost]
        public async Task<IActionResult> Create() 
        {
            return null;
        }
    }
}
