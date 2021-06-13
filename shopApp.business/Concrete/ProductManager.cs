using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopApp.business.Abstract;
using shopApp.data.Abstract;
using shopApp.data.Concrete.EfCore;
using shopApp.entity;

namespace shopApp.business.Concrete
{
    public class ProductManager : IProductService
    {

        private readonly IUnitOfWorks _unitOfWork;



        public ProductManager(string errorMessage)
        {
            this.ErrorMessage = errorMessage;

        }
        public string ErrorMessage { get; set; }

        public ProductManager(IUnitOfWorks unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        //İş kuraları uygulanır. 
        public bool Create(Product entity)
        {
            if (Validate(entity))
            {
                _unitOfWork.Products.Create(entity);
                _unitOfWork.Save();
                return true;
            }
            return false;

        }
        public async Task<Product> CreateAsync(Product entity)
        {
            await _unitOfWork.Products.CreateAsync(entity);
            await _unitOfWork.SaveAsync();
            return entity;
        }

        public void Delete(Product entity)
        {
            _unitOfWork.Products.Delete(entity);
            _unitOfWork.Save();
        }

        public async Task<Product> GetById(int id)
        {
            return await _unitOfWork.Products.GetById(id);
        }

        public Product GetByIdWithCategories(int id)
        {
            return _unitOfWork.Products.GetByIdWithCategories(id);
        }

        public int getCountCategory(string category)
        {
            return _unitOfWork.Products.getCountCategory(category);
        }

        public Product GetDetails(string productUrl)
        {
            return _unitOfWork.Products.GetDetails(productUrl);
        }

        public List<Product> getHomePageProducts()
        {
            return _unitOfWork.Products.getHomePageProducts();
        }

        public List<Product> getProductByCategpry(string Name, int page, int pageSize)
        {
            return _unitOfWork.Products.getProductByCategpry(Name, page, pageSize);
        }

        public List<Product> getSearchResult(string search)
        {

            return _unitOfWork.Products.getSearchResult(search);
        }

        public async Task<List<Product>> GetAll()
        {
            return await _unitOfWork.Products.GetAll();
        }

        public void Update(Product entity)
        {
            _unitOfWork.Products.Update(entity);
            _unitOfWork.Save();
        }

        public bool Update(Product entity, int[] Id)
        {
            if (Validate(entity))
            {
                if (Id.Length == 0)
                {
                    ErrorMessage += "You must a category for this product";
                    return false;
                }
                _unitOfWork.Products.Update(entity, Id);
                _unitOfWork.Save();
                return true;
            }
            return false;
        }

        public bool Validate(Product entity)
        {
            var isValid = true;
            if (string.IsNullOrEmpty(entity.Name))
            {
                ErrorMessage += "Enter product name \n";
                isValid = false;
            }
            // if (string.IsNullOrEmpty(entity.Description))
            // {
            //     ErrorMessage += "Enter product  description \n"; 
            //     isValid = false;
            // }

            if (entity.Price < 0)
            {
                ErrorMessage += "Product price cannot negative \n";
                isValid = false;
            }
            return isValid;
        }

        public async Task UpdateAsync(Product entityToUpdate, Product Entity)
        {
            entityToUpdate.Name = Entity.Name;
            entityToUpdate.Description = Entity.Description;
            entityToUpdate.Price = Entity.Price;
            entityToUpdate.ImageUrl = Entity.ImageUrl;
            entityToUpdate.IsApproved = Entity.IsApproved;
            entityToUpdate.IsHome = Entity.IsHome;
            entityToUpdate.DateAdded = Entity.DateAdded;
            await _unitOfWork.SaveAsync();

        }

        public async Task DeleteAsync(Product entity)
        {
              _unitOfWork.Products.Delete(entity);
           await _unitOfWork.SaveAsync();
        }
    }
}