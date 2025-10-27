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
        public DbSet<Claim_DM> Claims { get; set; }
        public DbSet<LecturerFiles_DM> LecturerFiles { get; set; }
        public DbSet<Programmes_DM> Programmes { get; set; }
        public DbSet<BankingDetails_DM> BankingDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // User
            modelBuilder.Entity<User_DM>()
                .HasKey(u => u.UserId);

            modelBuilder.Entity<User_DM>()
                .Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<User_DM>()
                .Property(u => u.Email)
                .IsRequired();

            modelBuilder.Entity<User_DM>()
                .HasMany(u => u.UserClaims)
                .WithOne(c => c.User)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // 1:1 with Banking
            modelBuilder.Entity<User_DM>()
                .HasOne<BankingDetails_DM>()
                .WithOne()
                .HasForeignKey<BankingDetails_DM>(b => b.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Claims
            modelBuilder.Entity<Claim_DM>()
                .HasKey(c => c.ClaimId);

            modelBuilder.Entity<Claim_DM>()
                .Property(c => c.ClaimTitle)
                .IsRequired()
                .HasMaxLength(100);

            // 1:* with Programmes
            modelBuilder.Entity<Claim_DM>()
                .HasOne(c => c.Programme)
                .WithMany()
                .HasForeignKey(c => c.ProgrammeCode)
                .OnDelete(DeleteBehavior.Restrict);

            // 1:* with LecturerFiles 
            modelBuilder.Entity<Claim_DM>()
                .HasMany(c => c.Files)
                .WithOne()
                .HasForeignKey(f => f.ClaimId)
                .OnDelete(DeleteBehavior.Cascade);

            // Programme
            modelBuilder.Entity<Programmes_DM>()
                .HasKey(p => p.ProgrammeCode);

            modelBuilder.Entity<Programmes_DM>()
                .Property(p => p.ProgrammeCode)
                .HasMaxLength(10);

            modelBuilder.Entity<Programmes_DM>()
                .Property(p => p.ProgrammeName)
                .IsRequired()
                .HasMaxLength(100);

            // Lecturer Files
            modelBuilder.Entity<LecturerFiles_DM>()
                .HasKey(f => f.LecFileId);

            modelBuilder.Entity<LecturerFiles_DM>()
                .Property(f => f.FileName)
                .IsRequired()
                .HasMaxLength(255);

            // Banking Details
            modelBuilder.Entity<BankingDetails_DM>()
                .HasKey(b => b.BankingDetailsId);

            modelBuilder.Entity<BankingDetails_DM>()
                .Property(b => b.BankName)
                .HasMaxLength(100);

            modelBuilder.Entity<BankingDetails_DM>()
                .Property(b => b.AccountNumber)
                .HasMaxLength(30);
        }
    }
}
