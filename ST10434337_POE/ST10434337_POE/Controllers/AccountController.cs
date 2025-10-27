using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ST10434337_POE.Data;
using ST10434337_POE.Models.DomainModels;
using ST10434337_POE.Models.ViewModels;
using ST10434337_POE.Services;

namespace ST10434337_POE.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly PasswordHelper _passwordHelper;

        public AccountController(AppDbContext context, PasswordHelper passwordHelper)
        {
            _context = context;
            _passwordHelper = passwordHelper;
        }



        // GET: /Account/Register
        [HttpGet]
        public IActionResult Register()
        {

            return View();
        }

        // POST: /Account/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(Register_VM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            // Check for duplicate username
            bool exists = await _context.Users.AnyAsync(u => u.Username == model.Username);
            if (exists)
            {
                ModelState.AddModelError("", "Username already exists. Please choose another.");
                return View(model);
            }

            // Hash password
            string hashed = _passwordHelper.HashPassword(model.Password);

            var user = new User_DM
            {
                Name = model.Name,
                Surname = model.Surname,
                Email = model.Email,
                Username = model.Username,
                PasswordHash = hashed,
                Roll = model.Roll
            };

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            TempData["Success"] = "Registration successful! You can now log in.";
            return RedirectToAction("Login");
        }

        // GET: /Account/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(Login_VM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            // Lookup username
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == model.Username);

            if (user == null || !_passwordHelper.VerifyPassword(model.Password, user.PasswordHash))
            {
                ModelState.AddModelError("", "Invalid username or password.");
                return View(model);
            }

            // Store basic user info in Session
            HttpContext.Session.SetInt32("UserId", user.UserId);
            HttpContext.Session.SetString("Username", user.Username);
            HttpContext.Session.SetInt32("Roll", user.Roll);

            return RedirectToAction("Index", "Home");
        }

        // GET: /Account/Logout
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
