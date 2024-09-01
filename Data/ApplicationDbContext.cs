using Microsoft.EntityFrameworkCore;
using AtulaDotnetTest.Models; 

namespace AtulaDotnetTest.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Sku = "SKUA", Name = "Lorem Table" },
                new Product { Id = 2, Sku = "SKUB", Name = "Ipsum Table" },
                new Product { Id = 3, Sku = "SKUC", Name = "Dolor Table" },
                new Product { Id = 4, Sku = "SKUD", Name = "Sit Chair" },
                new Product { Id = 5, Sku = "SKUE", Name = "Amet Chair" },
                new Product { Id = 6, Sku = "SKUF", Name = "Consectetur Chair" },
                new Product { Id = 7, Sku = "SKUG", Name = "Adipiscing Sofa" },
                new Product { Id = 8, Sku = "SKUH", Name = "Elit Sofa" },
                new Product { Id = 9, Sku = "SKUI", Name = "Mauris Sofa" }
    );
        }
    }
    
}