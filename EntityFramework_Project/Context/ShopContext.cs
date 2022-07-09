using EntityFramework_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework_Project.Context
{
    public class ShopContext:DbContext
    {

        public DbSet<Product> Products { get; set; }

        public ShopContext(DbContextOptions <ShopContext> options): base(options)
        {
            
        }

    }
}
