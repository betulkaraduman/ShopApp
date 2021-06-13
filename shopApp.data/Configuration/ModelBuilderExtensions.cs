using Microsoft.EntityFrameworkCore;
using shopApp.entity;

namespace shopApp.data.Configuration
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Product>().HasData(
               new Product() { Id = 1, Name = "Samsung A5", Price = 14, Description = "For Call", ImageUrl = "1.jpg", IsApproved = true, ProductUrl = "samsungA5" },
               new Product() { Id = 2, Name = "Phone 7", Price = 15, Description = "For Call", ImageUrl = "2.jpg", IsApproved = false, ProductUrl = "iphone7" },
               new Product() { Id = 3, Name = "Phone 8", Price = 16, Description = "For Call", ImageUrl = "3.jpg", IsApproved = true, ProductUrl = "iphone8" },
               new Product() { Id = 4, Name = "Phone 11", Price = 17, Description = "For Call", ImageUrl = "4.jpg", IsApproved = false, ProductUrl = "iphone11" }
           );
            builder.Entity<ProductCategory>().HasData(
            new ProductCategory() { ProductId = 1, CategoryId = 1 },
            new ProductCategory() { ProductId = 2, CategoryId = 2 },
            new ProductCategory() { ProductId = 2, CategoryId = 1 },
            new ProductCategory() { ProductId = 1, CategoryId = 2 },
            new ProductCategory() { ProductId = 1, CategoryId = 3 },
            new ProductCategory() { ProductId = 2, CategoryId = 3 });
            builder.Entity<Category>().HasData(
             new Category() { Id = 1, Name = "Phone", Description = "For Call", Url = "phone" },
          new Category() { Id = 2, Name = "Television", Description = "For Watch", Url = "television" },
          new Category() { Id = 3, Name = "Computer", Description = "For Watch", Url = "computer" });

        }
    }
}