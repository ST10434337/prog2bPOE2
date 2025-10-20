using Microsoft.AspNetCore.Mvc;
using ST10434337_POE.Models.ViewModels;

namespace ST10434337_POE.Controllers
{
    public class ChangeUserSessionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        /*
         Idea: Select A user to view layout as
        Then figure out how to select a specific person from that Type of User 
            Save User Type and Person Id 

        So we can build the who did what action when for lec, PC, AMs 
        Show in footer kind of user, and who is signed in 
         */

        [HttpGet]
        public IActionResult ChangeUser(User_VM user)
        {
            user.UserId = 1;
            user.Type = Models.UserType.ProgramCoordinator;

            return View();
        }
        [HttpPost]
        public IActionResult ChangeUser()
        {
            
            return View();
        }



    }
}
