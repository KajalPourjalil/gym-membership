// using Microsoft.EntityFrameworkCore;

// namespace gym_membership.Models
// {
//     public class GymDbContext : DbContext
//     {
//         public GymDbContext(DbContextOptions<GymDbContext> options) : base(options)
//         {
//         }

//         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//         {
//             if (!optionsBuilder.IsConfigured)
//             {
//                 optionsBuilder.UseSqlServer("Data Source=DESKTOP-19UR9HF\\SQLEXPRESS;Initial Catalog=GymDb;User ID=sa;Password=123;TrustServerCertificate=True");
//             }
//         }

//         public DbSet<GymTrainee> Trainees { get; set; }
//         public DbSet<BloodGroup> BloodGroups { get; set; }
//         public DbSet<TrainingLevel> TrainingLevels { get; set; }
//         public DbSet<MonthlyFeeVoucher> MonthlyFeeVouchers { get; set; }
//     }
// }


using Microsoft.EntityFrameworkCore;

namespace gym_membership.Models
{
    public class GymDbContext : DbContext
    {
        public GymDbContext(DbContextOptions<GymDbContext> options) : base(options)
        {
        }

        public DbSet<GymTrainee> Trainees { get; set; }
        public DbSet<BloodGroup> BloodGroups { get; set; }
        public DbSet<TrainingLevel> TrainingLevels { get; set; }
        public DbSet<MonthlyFeeVoucher> MonthlyFeeVouchers { get; set; }
    }
}
