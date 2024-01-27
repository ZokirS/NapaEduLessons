using Microsoft.EntityFrameworkCore;
using NapaEduLessons1.Configurations;
using NapaEduLessons1.Models;

namespace NapaEduLessons1.Context
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext()
        {
         // Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ADMIN; database=NapaEduDB; Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .HasOne(p => p.Passport)
                .WithOne(o => o.Person)
                .HasForeignKey<Passport>(x => x.PersonId);

            modelBuilder.Entity<Person>()
                .HasMany(p => p.Vehicles)
                .WithOne(x => x.Owner)
                .HasForeignKey(o => o.PersonId);

            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new PeopleConfiguration());
            modelBuilder.ApplyConfiguration(new PassportConfigurtion());
            modelBuilder.ApplyConfiguration(new VehiclesConfiguration());
        }
        public DbSet<Student>? Students { get; set; }
        public DbSet<Person>  Person { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
    }
}
