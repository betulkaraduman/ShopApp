using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using shopApp.entity;

namespace shopApp.data.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            // var context = new ShopContext();
            // if (context.Database.GetPendingMigrations().Count() == 0)
            // {
            //     if (context.Category.Count() == 0)
            //     {
            //         context.Category.AddRange(Categories);
            //     }
            //     if (context.Product.Count() == 0)
            //     {
            //         context.Product.AddRange(Products);
            //         context.AddRange(ProductCategories);
            //     }
            // }
            // context.SaveChanges();
        }
        private static Category[] Categories ={
            new Category(){Name="Phone",Description="For Call",Url="phone"},
            new Category(){Name="Television",Description="For Watch",Url="television"},
            new Category(){Name="Computer",Description="For Watch",Url="computer"}
        };
        private static Product[] Products ={
            new Product(){Name="Samsung A5",Price=14,Description="For Call",ImageUrl="1.jpg",IsApproved=true,ProductUrl="samsungA5"},
            new Product(){Name="Phone 7",Price=15,Description="For Call",ImageUrl="2.jpg",IsApproved=false,ProductUrl="iphone7"},
            new Product(){Name="Phone 8",Price=16,Description="For Call",ImageUrl="3.jpg",IsApproved=true,ProductUrl="iphone8"},
            new Product(){Name="Phone 11",Price=17,Description="For Call",ImageUrl="4.jpg",IsApproved=false,ProductUrl="iphone11"},
        };
        private static ProductCategory[] ProductCategories ={
            new ProductCategory(){Product=Products[0],Category=Categories[0]},
            new ProductCategory(){Product=Products[1],Category=Categories[1]},
            new ProductCategory(){Product=Products[2],Category=Categories[0]},
            new ProductCategory() { Product = Products[3],Category = Categories[2]}
    };
}
}