using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using shopApp.data.Abstract;
using shopApp.entity;

namespace shopApp.data.Concrete.EfCore
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category>, ICategoryRepository
    {
        public EfCoreCategoryRepository(ShopContext context) : base(context)
        {

        }

        private ShopContext ShopContext
        {
            get { return context as ShopContext; }
        }
        public void deleteFromCategory(int Id, int categoryId)
        {
            var cmd = "Delete From ProductCategory WHERE ProductId=@p0 AND CategoryId=@p1";
            ShopContext.Database.ExecuteSqlRaw(cmd, Id, categoryId);
        }

        public Category GetByIdWithProducts(int id)
        {
            return ShopContext.Category.Where(i => i.Id == id).Include(i => i.ProductCategories).ThenInclude(i => i.Product).FirstOrDefault();
        }

        public List<Category> GetPopularCategory()
        {
            return ShopContext.Category.ToList();
        }


    }
}