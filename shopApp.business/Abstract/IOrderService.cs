using System.Collections.Generic;
using shopApp.entity;

namespace shopApp.business.Abstract
{
    public interface IOrderService
    {
         void Create(Order entitt);
         List<Order> GetORders(string UserId);
    }
}