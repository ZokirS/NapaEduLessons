using Microsoft.EntityFrameworkCore;
using NapaEduWebAppMVC.Models;

namespace NapaEduWebAppMVC.Context
{
    public class AppDbContext: DbContext
    {
        public DbSet<Person> People{ get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        { }
    }
}
