using Microsoft.EntityFrameworkCore;
using shopApp.data.Configuration;
using shopApp.entity;

namespace shopApp.data.Concrete.EfCore
{
    public class ShopContext:DbContext
    {
        public ShopContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<CartItem> CartItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlite("Data Source=shopApp_DB");
        // }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.Seed();
            modelBuilder.Entity<ProductCategory>().HasKey(c=>new {c.CategoryId,c.ProductId});
          
        }



        
    }
}