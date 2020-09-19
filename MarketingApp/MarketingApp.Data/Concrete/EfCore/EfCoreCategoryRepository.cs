using System.Collections.Generic;
using System.Linq;
using MarketingApp.Data.Abstract;
using MarketingApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace MarketingApp.Data.Concrete.EfCore
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category, MarketingContext>, ICategoryRepository
    {
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