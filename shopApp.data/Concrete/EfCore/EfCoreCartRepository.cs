using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using shopApp.data.Abstract;
using shopApp.entity;

namespace shopApp.data.Concrete.EfCore
{
    public class EfCoreCartRepository : EfCoreGenericRepository<Cart>, ICartRepository
    {
        public EfCoreCartRepository(ShopContext context) : base(context)
        {

        }

        private ShopContext ShopContext
        {
            get { return context as ShopContext; }
        }
        public void AddToCart(string UserId, int ProductId, int quantity)
        {
            throw new NotImplementedException();
        }

        public void ClearCart(int cartId)
        {
            var cmd = @"delete from CartItem where CartId=@p0";
            ShopContext.Database.ExecuteSqlRaw(cmd, cartId);

        }

        public void DeleteFromCart(int CartId, int ProductId)
        {
            var cmd = @"delete from CartItem where CartId=@p0 and ProductId=@p1";
            ShopContext.Database.ExecuteSqlRaw(cmd, CartId, ProductId);

        }

        public Cart getByUserId(string userId)
        {
            return ShopContext.Cart.Include(i => i.CartItems).ThenInclude(p => p.Product).FirstOrDefault(i => i.UserId == userId);
        }
        public override void Update(Cart entity)
        {
            ShopContext.Cart.Update(entity);
            ShopContext.SaveChanges();
        }


    }
}