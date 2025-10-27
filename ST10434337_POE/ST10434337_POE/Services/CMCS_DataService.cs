using Microsoft.EntityFrameworkCore;
using ST10434337_POE.Data;
using ST10434337_POE.Models.DomainModels;

namespace ST10434337_POE.Services
{
    /// <summary>
    /// Used to instanciate in memory data of Domain Models/Tables
    /// </summary>
    public class CMCS_DataService 
    {
        private readonly AppDbContext _context;

        public CMCS_DataService(AppDbContext context)
        {
            _context = context;
        }

        public async Task SeedDataAsync()
        {
            // Add Demo Programmes
            if (!await _context.Programmes.AnyAsync())
            {
                var programmes = new List<Programmes_DM>
                {
                    new Programmes_DM { ProgrammeCode = "PROG6212", ProgrammeName = "Programming 2B" },
                    new Programmes_DM { ProgrammeCode = "INSY7213", ProgrammeName = "Information Systems 2C" },
                    new Programmes_DM { ProgrammeCode = "CLDV6212", ProgrammeName = "Cloud Development B" }
                };

                await _context.Programmes.AddRangeAsync(programmes);
            }

            // Add Demo Users
            if (!await _context.Users.AnyAsync())
            {
                var adminHash = BCrypt.Net.BCrypt.EnhancedHashPassword("Admin123", 13);
                var lecturerHash = BCrypt.Net.BCrypt.EnhancedHashPassword("Lecturer123", 13);

                var users = new List<User_DM>
                {
                    new User_DM
                    {
                        Name = "Alice",
                        Surname = "Manager",
                        Email = "alice.manager@cmcs.com",
                        Username = "admin",
                        PasswordHash = adminHash,
                        Roll = 1 // Academic Manager
                    },
                    new User_DM
                    {
                        Name = "Bob",
                        Surname = "Lecturer",
                        Email = "bob.lec@cmcs.com",
                        Username = "bob",
                        PasswordHash = lecturerHash,
                        Roll = 4 // Lecturer
                    }
                };

                await _context.Users.AddRangeAsync(users);
            }

            // Add Demo Banking Details
            if (!await _context.BankingDetails.AnyAsync())
            {
                var banking = new List<BankingDetails_DM>
                {
                    new BankingDetails_DM { UserId = 1, BankName = "Capitec", BankBranch = "Cape Town", AccountNumber = "100200300" },
                    new BankingDetails_DM { UserId = 2, BankName = "FNB", BankBranch = "Durban", AccountNumber = "987654321" }
                };

                await _context.BankingDetails.AddRangeAsync(banking);
            }

            // Add Demo Claim
            if (!await _context.Claims.AnyAsync())
            {
                var claim = new Claim_DM
                {
                    ClaimTitle = "Marking Assignments",
                    HoursWorked = TimeSpan.FromHours(12),
                    RatePerHour = 250.00m,
                    SubmissionNote = "Completed marking for module PROG6212",
                    ProgrammeCode = "1", // "PROG6212"
                    UserId = 2, // Bob the lecturer
                    ClaimStatus = 1
                };

                await _context.Claims.AddAsync(claim);
            }

            // Save all changes at once
            await _context.SaveChangesAsync();
        }
    }
}
