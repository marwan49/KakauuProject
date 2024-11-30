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

            // Configurando relacionamentos
            modelBuilder.Entity<Chocolate>()
                .HasOne(c => c.Brand)
                .WithMany(b => b.Chocolates) // Relacionamento com a coleção Chocolates
                .HasForeignKey(c => c.BrandId);
        }

        // DbSets para as tabelas
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Chocolate> Chocolates { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
