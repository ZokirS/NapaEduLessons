using Microsoft.EntityFrameworkCore;
using WebApplicationAPIBasic.Models;

namespace WebApplicationAPIBasic.Context
{
    public class AppDbContext: DbContext
    {
        public DbSet<Student> Students { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }
        
    }
}
