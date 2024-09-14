using eKakauu.Models;
using Microsoft.EntityFrameworkCore;
namespace eKakauu.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Cocoa> Cocoas { get; set; }
        public DbSet<Chocolate> chocolates { get; set; }
    }
}
