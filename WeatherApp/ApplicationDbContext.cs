using Microsoft.EntityFrameworkCore;
using WeatherApp.Models.Entity;

namespace WeatherApp
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Location> Location{ get; set; }
        public DbSet<HourlyInfo> Hourly { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ADMIN; database=WeatherDb; Integrated Security=true;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>()
                .HasMany(x => x.Hourly)
                .WithOne(p => p.Location)
                .HasForeignKey(p => p.LocationId);
        }
    }
}
