using System.Collections.Generic;
using System.Linq;
using MarketingApp.Business.Abstract;
using MarketingApp.Data.Abstract;
using MarketingApp.Entity;

namespace MarketingApp.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
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
            return _productRepository.GeProductstHomePage();
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
            return _productRepository.GetProductsByCategory(name, page, pageSize);
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