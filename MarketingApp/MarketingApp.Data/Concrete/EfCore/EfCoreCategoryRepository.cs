using System.Collections.Generic;
using MarketingApp.Data.Abstract;
using MarketingApp.Entity;

namespace MarketingApp.Data.Concrete.EfCore
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category, MarketingContext>, ICategoryRepository
    {
        public List<Category> GetPopularCategories()
        {
            throw new System.NotImplementedException();
        }
    }
}