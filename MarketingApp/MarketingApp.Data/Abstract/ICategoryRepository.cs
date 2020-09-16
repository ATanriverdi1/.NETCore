using System.Collections.Generic;
using MarketingApp.Entity;

namespace MarketingApp.Data.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
         List<Category> GetPopularCategories();
    }
}