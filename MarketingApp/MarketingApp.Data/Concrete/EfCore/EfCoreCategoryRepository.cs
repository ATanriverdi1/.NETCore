using System.Collections.Generic;
using System.Linq;
using MarketingApp.Data.Abstract;
using MarketingApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace MarketingApp.Data.Concrete.EfCore
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category, MarketingContext>, ICategoryRepository
    {
        public void DeleteProductFromCategory(int productId, int categoryId)
        {
            using (var context = new MarketingContext())
            {
                var cmd = "delete from productcategory where ProductId = @p0 and CategoryId = @p1";
                context.Database.ExecuteSqlRaw(cmd,productId,categoryId);
            }
        }

        public Category GetByIdWithProduct(int categoryId)
        {
            using (var context = new MarketingContext())
            {
                return context.Categories
                            .Where(c=>c.CategoryId == categoryId)
                            .Include(pc=>pc.productCategories)
                            .ThenInclude(p=>p.Product)
                            .FirstOrDefault();
            }
        }
    }
}