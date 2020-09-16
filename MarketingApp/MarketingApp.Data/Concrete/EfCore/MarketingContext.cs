using System.Collections.Generic;
using MarketingApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace MarketingApp.Data.Concrete.EfCore
{
    public class MarketingContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Marketing.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>()
                .HasKey(c=> new {c.CategoryId,c.ProductId});
        }
    }
}