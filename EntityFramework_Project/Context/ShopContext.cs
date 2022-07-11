using EntityFramework_Project.Mapping;
using EntityFramework_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework_Project.Context
{
    public class ShopContext:DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorBiography> AuthorBiographies { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }

        public ShopContext(DbContextOptions <ShopContext> options): base(options)
        {
            
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductMapping());
            modelBuilder.ApplyConfiguration(new ProductCategoryMapping());
            modelBuilder.ApplyConfiguration(new AuthorMapping());
            modelBuilder.ApplyConfiguration(new AuthorBiographyMapping());
            modelBuilder.ApplyConfiguration(new BookCategoryMapping());
            modelBuilder.ApplyConfiguration(new BookMapping());


            base.OnModelCreating(modelBuilder);
        }
    }
}
