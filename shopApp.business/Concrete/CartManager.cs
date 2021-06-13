using System;
using shopApp.business.Abstract;
using shopApp.data.Abstract;
using shopApp.entity;

namespace shopApp.business.Concrete
{
    public class CartManager : ICartService
    {
        private readonly IUnitOfWorks _unitOfWork;
   
        public CartManager(IUnitOfWorks unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public string ErrorMessage { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void AddToCard(string UserId, int ProductId, int quantity)
        {
            var cart = GetCartByUserId(UserId);
            if (cart != null)
            {
                //eklenmek isteyen ürün sepette mi 
                var index = cart.CartItems.FindIndex(i => i.ProductId == ProductId);
                if (index < 0)
                {   //yeni ürün
                    cart.CartItems.Add(new CartItem()
                    {
                        ProductId = ProductId,
                        Quantity = quantity,
                        CartId = cart.Id
                    });
                }
                else
                {
                    cart.CartItems[index].Quantity += quantity;

                }
               _unitOfWork.Carts.Update(cart);
            }

            // _Repo.AddToCart(UserId, ProductId, quantity);
        }

        public void ClearCart(int CartId)
        {
           _unitOfWork.Carts.ClearCart(CartId);
        }

        public void DeleteFromCart(string UserId, int ProductId)
        {
           var cart=GetCartByUserId(UserId);
           if(cart!=null){
               _unitOfWork.Carts.DeleteFromCart(cart.Id,ProductId);
           }
        }

        public Cart GetCartByUserId(string UserId)
        {
            return _unitOfWork.Carts.getByUserId(UserId);
        }

        public void InıtializeCard(string UserId)
        {
            _unitOfWork.Carts.Create(new Cart() { UserId = UserId });
            _unitOfWork.Save();
        }

        public bool Validate(Cart entity)
        {
            throw new System.NotImplementedException();
        }
    }
}