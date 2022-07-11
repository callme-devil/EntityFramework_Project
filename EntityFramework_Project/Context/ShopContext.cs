using EntityFramework_Project.Mapping;
using EntityFramework_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework_Project.Context
{
    public class ShopContext:DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        public ShopContext(DbContextOptions <ShopContext> options): base(options)
        {
            
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductMapping());
            modelBuilder.ApplyConfiguration(new ProductCategoryMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
