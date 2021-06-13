using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using shopApp.data.Abstract;
using shopApp.entity;

namespace shopApp.data.Concrete.EfCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product>, IProductRepository
    {
        public EfCoreProductRepository(ShopContext context) : base(context)
        {

        }

        private ShopContext ShopContext
        {
            get { return context as ShopContext; }
        }
        public Product GetByIdWithCategories(int Id)
        {

            var product = ShopContext.Product.Where(p => p.Id == Id).Include(c => c.ProductCategories).ThenInclude(c => c.Category).FirstOrDefault();
            return product;

        }

        public int getCountCategory(string categoy)
        {

            var products = ShopContext.Product.Where(i => i.IsApproved).AsQueryable();
            if (!string.IsNullOrEmpty(categoy))
            {
                products = products.Include(i => i.ProductCategories).ThenInclude(c => c.Category).Where(c => c.ProductCategories.Any(a => a.Category.Url.ToLower() == categoy.ToLower()));
            }

            return products.Count();
        }

        public Product GetDetails(string productUrl)
        {

            return ShopContext.Product.Where(i => i.ProductUrl == productUrl).Include(i => i.ProductCategories).ThenInclude(pc => pc.Category).FirstOrDefault();

        }


        public List<Product> getHomePageProducts()
        {

            return ShopContext.Product
                .Where(i => i.IsApproved && i.IsHome).ToList();

        }

        public List<Product> getPopularProducts()
        {

            return ShopContext.Product.ToList();

        }

        public List<Product> getProductByCategpry(string Name, int page, int pageSize)
        {

            var products = ShopContext.Product.Where(i => i.IsApproved).AsQueryable();
            if (!string.IsNullOrEmpty(Name))
            {
                products = products.Include(i => i.ProductCategories).ThenInclude(c => c.Category).Where(c => c.ProductCategories.Any(a => a.Category.Url.ToLower() == Name.ToLower()));
            }

            return products.Skip((page - 1) * pageSize).Take(pageSize).ToList();
        }

        public List<Product> getSearchResult(string search)
        {

            var products = ShopContext.Product.Where(i => i.IsApproved && (i.Name.Contains(search) || i.Description.Contains(search))).AsQueryable();
            return products.ToList();

        }

        public void Update(Product entity, int[] Id)
        {

            var product = ShopContext.Product.Include(i => i.ProductCategories).
            FirstOrDefault(i => i.Id == entity.Id);

            if (product != null)
            {
                product.Name = entity.Name;
                product.Description = entity.Description;
                product.Price = entity.Price;
                product.ProductUrl = entity.ProductUrl;
                product.ImageUrl = entity.ImageUrl;
                product.IsHome = entity.IsHome;
                product.IsApproved = entity.IsApproved;
                product.ProductCategories = Id.Select(ids => new ProductCategory()
                {
                    ProductId = entity.Id,
                    CategoryId = ids
                }).ToList();
                // context.SaveChanges();
            }

        }
    }
}