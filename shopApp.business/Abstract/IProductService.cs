
using System.Collections.Generic;
using System.Threading.Tasks;
using shopApp.entity;

namespace shopApp.business.Abstract
{
    public interface IProductService:IValidatior<Product>
    {
       Task<Product> GetById(int id);
        Product GetByIdWithCategories(int id);
        Product GetDetails(string productUrl);
        int getCountCategory(string category);
       Task<List<Product>> GetAll();
        List<Product> getHomePageProducts();
        List<Product> getSearchResult(string search);
        List<Product> getProductByCategpry(string Name, int page, int pageSize);
        bool Create(Product entity);
        Task<Product> CreateAsync(Product entity);
        Task UpdateAsync(Product entityToUpdate,Product Entity);
        void Delete(Product entity);
        Task DeleteAsync(Product entity);
        void Update(Product entity);
        bool Update(Product entity, int[] Id);
    }
}