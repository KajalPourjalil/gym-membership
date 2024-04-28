using Microsoft.EntityFrameworkCore;

namespace gym_membership.Models
{
    public class GymDbContext : DbContext
    {

        // public GymDbContext(DbContextOptions<DbContext> options) : base(options)
        // {

        // }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>

            options.UseSqlServer(@"Data Source = DESKTOP-19UR9HF\SQLEXPRESS;Initial Catalog=GymDb;UserId=sa;Password=123;TrustServerCertificate=True");

        public DbSet<GymTrainee> Trainees { get; set; }

        public DbSet<BloodGroup> BloodGroups { get; set; }

        public DbSet<TrainingLevel> TrainingLevels { get; set; }

        public DbSet<MonthlyFeeVoucher> MonthlyFeeVouchers { get; set; }


    }
} 