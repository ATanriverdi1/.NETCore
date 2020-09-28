using System.Collections.Generic;
using MarketingApp.Entity;
using Microsoft.Extensions.Caching.Memory;

namespace MarketingApp.Business.Abstract
{
    public interface IProductService
    {
        Product GetByIdWithCategory(int productId);
        List<Product> GetSearchResult(string searchString);
        Product GetProductDetails(string url);
        List<Product> GetProductsByCategory(string name, int page, int pageSize);
        Product GetById(int id);
        int GetCountByCategory(string category);
        List<Product> GetAll();
        List<Product> GeProductstHomePage();
        void Create(Product entity);
        void Create(Product entity, int[] categoryIds);
        
        void Update(Product entity);
        void Update(Product entity,int[] categoryIds);
        
        void Delete(Product entity);
    }
}