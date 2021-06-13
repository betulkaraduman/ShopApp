using System.Collections.Generic;
using shopApp.business.Abstract;
using shopApp.data.Abstract;
using shopApp.entity;

namespace shopApp.business.Concrete
{
    public class OrderManager : IOrderService
    {

        private readonly IUnitOfWorks _unitOfWork;

        public OrderManager(IUnitOfWorks unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Create(Order entitt)
        {
            _unitOfWork.Orders.Create(entitt);
            _unitOfWork.Save();
        }

        public List<Order> GetORders(string UserId)
        {
            return _unitOfWork.Orders.getOrders(UserId);
        }
    }
}