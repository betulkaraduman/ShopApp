using System.Collections.Generic;
using System.Threading.Tasks;
using shopApp.business.Abstract;
using shopApp.data.Abstract;
using shopApp.entity;

namespace shopApp.business.Concrete
{
    public class CategoryManager : ICategoryService
    {


        private readonly IUnitOfWorks _unitOfWork;


        public CategoryManager(string errorMessage)
        {
            this.ErrorMessage = errorMessage;

        }
        public string ErrorMessage { get; set; }

        public CategoryManager(IUnitOfWorks unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Create(Category entity)
        {
            _unitOfWork.Categories.Create(entity);
        }

        public void Delete(Category entity)
        {
            _unitOfWork.Categories.Delete(entity);
            _unitOfWork.Save();
        }

        public void deleteFromCategory(int Id, int categoryId)
        {
            _unitOfWork.Categories.deleteFromCategory(Id, categoryId);
        }

        public async Task<Category> GetById(int id)
        {
            return await _unitOfWork.Categories.GetById(id);
        }

        public Category GetByIdWithProducts(int id)
        {
            return _unitOfWork.Categories.GetByIdWithProducts(id);
        }

        public async Task<List<Category>> GetAll()
        {
            return await _unitOfWork.Categories.GetAll();
        }

        public void Update(Category entity)
        {
            _unitOfWork.Categories.Update(entity);
            _unitOfWork.Save();
        }

        public bool Validate(Category entity)
        {
            throw new System.NotImplementedException();
        }


        public async Task<Category> CreateAsync(Category entity)
        {
            await _unitOfWork.Categories.CreateAsync(entity);
            await _unitOfWork.SaveAsync();
            return entity; 
        }

      
    }
}