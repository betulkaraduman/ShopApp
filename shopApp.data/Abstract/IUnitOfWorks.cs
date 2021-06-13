using System;
using System.Threading.Tasks;

namespace shopApp.data.Abstract
{
    public interface IUnitOfWorks : IDisposable
    {
        ICartRepository Carts { get; }
        ICategoryRepository Categories { get; }
        IOrderRepository Orders { get; }
        IProductRepository Products { get; }
        void Save();
        Task<int> SaveAsync();


    }
}