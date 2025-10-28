using Microsoft.EntityFrameworkCore;
using ST10434337_POE.Models.DomainModels;

namespace ST10434337_POE.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Set Tables
        public DbSet<User_DM> Users { get; set; }
        public DbSet<BankingDetails_DM> BankingDetails { get; set; }
        public DbSet<Programmes_DM> Programmes { get; set; }
        public DbSet<Claim_DM> Claims { get; set; }
        public DbSet<LecturerFiles_DM> LecturerFiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // USER -> CLAIMS (1 : Many)
            modelBuilder.Entity<User_DM>()
                .HasMany(u => u.Claims)
                .WithOne(c => c.User)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // USER -> BANKINGDETAILS (1 : 1)
            modelBuilder.Entity<User_DM>()
                .HasOne(u => u.BankingDetails)
                .WithOne(b => b.User)
                .HasForeignKey<BankingDetails_DM>(b => b.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // PROGRAMME -> CLAIMS (1 : Many)
            modelBuilder.Entity<Programmes_DM>()
                .HasMany(p => p.Claims)
                .WithOne(c => c.Programme)
                .HasForeignKey(c => c.ProgrammeId)
                .OnDelete(DeleteBehavior.Restrict);

            // CLAIM -> FILES (1 : Many)
            modelBuilder.Entity<Claim_DM>()
                .HasMany(c => c.Files)
                .WithOne(f => f.Claim)
                .HasForeignKey(f => f.ClaimId)
                .OnDelete(DeleteBehavior.Cascade);

            
            // Unique username constraint
            modelBuilder.Entity<User_DM>()
                .HasIndex(u => u.Username)
                .IsUnique();
        }
    }
}
