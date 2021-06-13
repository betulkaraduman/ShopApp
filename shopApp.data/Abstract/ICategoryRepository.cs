using System.Collections.Generic;
using shopApp.entity;

namespace shopApp.data.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        List<Category> GetPopularCategory();
        Category GetByIdWithProducts(int id);
        void deleteFromCategory(int Id,int categoryId);
    }
}