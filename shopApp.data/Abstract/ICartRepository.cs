using shopApp.entity;

namespace shopApp.data.Abstract
{
    public interface ICartRepository:IRepository<Cart>
    {
        Cart getByUserId(string UserId);
        void AddToCart(string UserId,int ProductId,int quantity);
        void DeleteFromCart(int CartId,int ProductId);
        void ClearCart(int cartId);
    }
}