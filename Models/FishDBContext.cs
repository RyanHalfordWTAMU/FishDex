using Microsoft.EntityFrameworkCore;
namespace Models
{
    public class FishDBContext : DbContext
    {
        public FishDBContext(DbContextOptions<FishDBContext> options) : base(options)
        {
        }
        public DbSet<Lake> Lake { get; set; }
        public DbSet<Fish> Fish { get; set; }
    }
}