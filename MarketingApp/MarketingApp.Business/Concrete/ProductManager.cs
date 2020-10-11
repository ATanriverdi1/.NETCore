using System;
using System.Collections.Generic;
using System.Linq;
using MarketingApp.Business.Abstract;
using MarketingApp.Data.Abstract;
using MarketingApp.Data.Concrete.EfCore;
using MarketingApp.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace MarketingApp.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;
        private IMemoryCache _memoryCache;
        public ProductManager(IProductRepository productRepository, IMemoryCache memoryCache)
        {
            _productRepository = productRepository;
            _memoryCache = memoryCache;
        }

        public void Create(Product entity)
        {
            //Business Rules
            _productRepository.Create(entity);
        }

        public void Create(Product entity, int[] categoryIds)
        {
            _productRepository.Create(entity,categoryIds);
        }

        public void Delete(Product entity)
        {
            _productRepository.Delete(entity);
        }

        public List<Product> GeProductstHomePage()
        {
            if (_memoryCache.TryGetValue("productsHome", out List<Product> productsHome))
            {
                return productsHome;
            }

            productsHome = _productRepository.GeProductstHomePage();
            var memoryCacheEntryOptions = new MemoryCacheEntryOptions();
            memoryCacheEntryOptions.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(1);
            _memoryCache.Set("productsHome",productsHome,memoryCacheEntryOptions);
            return productsHome;
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public Product GetByIdWithCategory(int productId)
        {
            return _productRepository.GetByIdWithCategory(productId);
        }

        public int GetCountByCategory(string category)
        {
            return _productRepository.GetCountByCategory(category);
        }

        public Product GetProductDetails(string url)
        {
            return _productRepository.GetProductDetails(url);
        }

        public List<Product> GetProductsByCategory(string name, int page, int pageSize)
        {
            return _productRepository.GetProductsByCategory(name,page,pageSize);
        }

        public List<Product> GetSearchResult(string searchString)
        {
            return _productRepository.GetSearchResult(searchString);
        }

        public void Update(Product entity)
        {
            _productRepository.Update(entity);
        }

        public void Update(Product entity, int[] categoryIds)
        {
            _productRepository.Update(entity,categoryIds);
        }
    }
}