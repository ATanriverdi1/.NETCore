using System.Collections.Generic;
using MarketingApp.Entity;

namespace MarketingApp.Data.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Category GetByIdWithProduct(int categoryId);

        void DeleteProductFromCategory(int productId, int categoryId);
    }
}