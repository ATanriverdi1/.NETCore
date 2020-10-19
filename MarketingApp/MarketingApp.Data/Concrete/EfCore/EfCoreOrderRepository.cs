using System.Collections.Generic;
using System.Linq;
using MarketingApp.Data.Abstract;
using MarketingApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace MarketingApp.Data.Concrete.EfCore
{
    public class EfCoreOrderRepository : EfCoreGenericRepository<Order, MarketingContext>, IOrderRepository
    {
        public List<Order> GetOrders(string userId)
        {
            using (var context = new MarketingContext())
            {
                var orders = context.Orders
                                    .Include(i=>i.OrderItems)
                                    .ThenInclude(i=>i.Product)
                                    .AsQueryable();
                if (!string.IsNullOrEmpty(userId))
                {
                    orders = orders.Where(i=>i.UserId == userId);
                }

                return orders.ToList();
            }
        }
    }
}