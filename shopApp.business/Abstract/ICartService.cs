using shopApp.entity;

namespace shopApp.business.Abstract
{
    public interface ICartService : IValidatior<Cart>
    {
        void InıtializeCard(string UserId);
        Cart GetCartByUserId(string UserId);
        void AddToCard(string UserId, int ProductId, int quantity);
        void DeleteFromCart(string UserId, int ProductId);
        void ClearCart(int CartId); 

    }
}