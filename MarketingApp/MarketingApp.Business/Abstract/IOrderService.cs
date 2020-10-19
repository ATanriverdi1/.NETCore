using System.Collections.Generic;
using MarketingApp.Entity;

namespace MarketingApp.Business.Abstract
{
    public interface IOrderService
    {
        void Create(Order entity);
        List<Order> GetOrders(string userId);
    }
}