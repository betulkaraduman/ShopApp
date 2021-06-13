using System.Collections.Generic;
using shopApp.entity;

namespace shopApp.data.Abstract
{
    public interface IOrderRepository : IRepository<Order>
    {
        List<Order> getOrders(string userId);
    }
}