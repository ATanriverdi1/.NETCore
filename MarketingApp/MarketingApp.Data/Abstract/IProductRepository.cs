using System.Collections.Generic;
using MarketingApp.Entity;

namespace MarketingApp.Data.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        Product GetProductDetails(string url);
        List<Product> GetProductsByCategory(string url, int page, int pageSize);
        int GetCountByCategory(string category);
        List<Product> GetSearchResult(string searchString);
        List<Product> GeProductstHomePage();
        Product GetByIdWithCategory(int productId);

        void Update(Product entity, int[] categoryIds);
    }
}