using System.Linq;
using MarketingApp.Data.Abstract;
using MarketingApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace MarketingApp.Data.Concrete.EfCore
{
    public class EfCoreCartRepository : EfCoreGenericRepository<Cart, MarketingContext>, ICartRepository
    {
        public void ClearCart(int cartId)
        {
            using (var context = new MarketingContext())
            {
                var cmd = @"delete from CartItems where CartId=@p0";
                context.Database.ExecuteSqlRaw(cmd,cartId);
            }
        }

        public void DeleteFromCart(int cartId, int productId)
        {
            using (var context = new MarketingContext())
            {
                var cmd = @"delete from CartItems where CartId=@p0 and ProductId=@p1";
                context.Database.ExecuteSqlRaw(cmd,cartId,productId);
            }
        }

        public Cart GetByUserId(string userId)
        {
            using (var context = new MarketingContext())
            {
                return context.Carts
                            .Include(ci=>ci.CartItems)
                            .ThenInclude(p=>p.Product)
                            .FirstOrDefault(i=>i.UserId == userId);
            }
        }

        public override void Update(Cart entity)
        {
            using (var context = new MarketingContext())
            {
                context.Carts.Update(entity);
                context.SaveChanges();
            }
        }
    }
}