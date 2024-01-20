using Microsoft.EntityFrameworkCore;
using NapaEduLessons1.Models;

namespace NapaEduLessons1.Context
{
    public class MyAppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ADMIN; database=sampleDB; Integrated Security=true");
        }
    }
}
