using System.Collections.Generic;
using MarketingApp.Entity;

namespace MarketingApp.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetSearchResult(string searchString);
        Product GetProductDetails(string url);
        List<Product> GetProductsByCategory(string name, int page, int pageSize);
        Product GetById(int id);
        int GetCountByCategory(string category);
        List<Product> GetAll();
        List<Product> GeProductstHomePage();
        void Create(Product entity);
        
        void Update(Product entity);
        
        void Delete(Product entity);
    }
}