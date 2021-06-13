using System.Collections.Generic;
using System.Threading.Tasks;
using shopApp.entity;

namespace shopApp.business.Abstract
{
    public interface ICategoryService : IValidatior<Category>
    {
        Task<Category> GetById(int id);
        Category GetByIdWithProducts(int id);
        Task<List<Category>> GetAll();
        void Create(Category entity);
        void Delete(Category entity);

        Task<Category> CreateAsync(Category entity); 
        void Update(Category entity);
        void deleteFromCategory(int Id, int categoryId);
    }
}