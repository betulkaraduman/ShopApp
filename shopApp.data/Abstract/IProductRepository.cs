using System.Collections.Generic;
using shopApp.entity;

namespace shopApp.data.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        Product GetDetails(string productUrl);
        Product GetByIdWithCategories(int Id);
        void Update(Product entity, int[] Id);
        int getCountCategory(string categoy);
        List<Product> getPopularProducts();
        List<Product> getHomePageProducts();
        List<Product> getSearchResult(string search);
        List<Product> getProductByCategpry(string Name, int page, int pageSize);


    }
}