using Microsoft.EntityFrameworkCore;
using NapaEduLessons1.Configurations;
using NapaEduLessons1.Models;

namespace NapaEduLessons1.Context
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext()
        {
          Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ADMIN; database=NapaEduDB; Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //One-to-One connection
            modelBuilder.Entity<Person>()
                .HasOne(p => p.Passport)
                .WithOne(o => o.Person)
                .HasForeignKey<Passport>(x => x.PersonId);

            //One-to-Many connection
            modelBuilder.Entity<Person>()
                .HasMany(p => p.Vehicles)
                .WithOne(x => x.Owner)
                .HasForeignKey(o => o.PersonId);

            //Many-to-Many connection
            modelBuilder.Entity<Student>()
                .HasMany(p => p.Courses)
                .WithMany(c => c.Students);

            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new PeopleConfiguration());
            modelBuilder.ApplyConfiguration(new PassportConfigurtion());
            modelBuilder.ApplyConfiguration(new VehiclesConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
        }
        public DbSet<Student>? Students { get; set; }
        public DbSet<Person>  Person { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<Course> Course { get; set; }
    }
}
