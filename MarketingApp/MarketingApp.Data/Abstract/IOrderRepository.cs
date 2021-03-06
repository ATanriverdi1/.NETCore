using System.Collections.Generic;
using MarketingApp.Entity;

namespace MarketingApp.Data.Abstract
{
    public interface IOrderRepository : IRepository<Order>
    {
        List<Order> GetOrders(string userId);
    }
}