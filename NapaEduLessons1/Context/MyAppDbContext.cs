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
            optionsBuilder.UseSqlServer("server=ADMIN; database=practiseDB2; Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
        }
        public DbSet<Student>? Students { get; set; }

    }
}
