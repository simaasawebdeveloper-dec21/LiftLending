using Microsoft.EntityFrameworkCore;

namespace LiftLending.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<UserData> UserData { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
