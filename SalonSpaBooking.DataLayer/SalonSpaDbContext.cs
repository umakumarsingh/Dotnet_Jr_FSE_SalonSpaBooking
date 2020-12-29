using Microsoft.EntityFrameworkCore;
using SalonSpaBooking.Entities;

namespace SalonSpaBooking.DataLayer
{
    public class SalonSpaDbContext : DbContext
    {
        public SalonSpaDbContext(DbContextOptions<SalonSpaDbContext> dbContextOptions)
            : base(dbContextOptions)
        {
            //Database.Migrate();
        }
        /// <summary>
        /// Creating DbSet for Table
        /// </summary>
        public DbSet<User> Users { get; set; }
        public DbSet<ServicesPlan> ServicesPlans { get; set; }
        public DbSet<SalonServices> Servicess { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        /// <summary>
        /// While Model or Table creating Applaying Primary key to Table
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(x => x.UserId);
            modelBuilder.Entity<ServicesPlan>()
                .HasKey(x => x.PlanId);
            modelBuilder.Entity<SalonServices>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Appointment>()
                .HasKey(x => x.AppointmentId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
