using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using shopApp.data.Abstract;
using shopApp.entity;

namespace shopApp.data.Concrete.EfCore
{
    public class EfCoreOrderRepository : EfCoreGenericRepository<Order>, IOrderRepository
    {
        public EfCoreOrderRepository(ShopContext context) : base(context)
        {

        }

        private ShopContext ShopContext
        {
            get { return context as ShopContext; }
        }
        public List<Order> getOrders(string userId)
        {
            var orders = ShopContext.Order.Include(i => i.OrderItems).ThenInclude(i => i.Product).AsQueryable();
            if (!string.IsNullOrEmpty(userId))
            {
                orders = orders.Where(i => i.UserId == userId);
            }
            return orders.ToList();
        }
    }
}