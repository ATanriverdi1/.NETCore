using System.Collections.Generic;
using System.Linq;
using MarketingApp.Data.Abstract;
using MarketingApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace MarketingApp.Data.Concrete.EfCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product, MarketingContext>, IProductRepository
    {
        public List<Product> GeProductstHomePage()
        {
            using (var context = new MarketingContext()) 
            {
                return context.Products.Where(i=>i.IsApproved && i.IsHomePage).ToList();
            }
        }

        public int GetCountByCategory(string category)
        {
            using(var _context = new MarketingContext())
            {
                var products = _context.Products.AsQueryable();
                if (!string.IsNullOrEmpty(category))
                {
                    products = products
                                    .Include(i=>i.productCategories)
                                    .ThenInclude(i=>i.Category)
                                    .Where(i=>i.productCategories.Any(a=>a.Category.Url == category));
                }
                return products.Count();
            } 
        }

        public List<Product> GetPopularProducts()
        {
            using(var _context = new MarketingContext())
            {
                return _context.Products.ToList();
            }
        }

        public Product GetProductDetails(string url)
        {
            using(var _context = new MarketingContext())
            {
                return _context.Products
                                .Where(i=>i.Url == url)
                                .Include(i=>i.productCategories)
                                .ThenInclude(i=>i.Category)
                                .FirstOrDefault();
            }
        }

        public List<Product> GetProductsByCategory(string url, int page, int pageSize)
        {
            using (var _context = new MarketingContext())
            {
                var products = _context.Products.AsQueryable();
                if (!string.IsNullOrEmpty(url))
                {
                    products = products
                                    .Include(i=>i.productCategories)
                                    .ThenInclude(i=>i.Category)
                                    .Where(i=>i.productCategories.Any(a=>a.Category.Url == url));
                }
                return products.Skip((page-1)*pageSize).Take(pageSize).ToList();
            }
        }

        public List<Product> GetSearchResult(string searchString)
        {
            using (var _context = new MarketingContext())
            {
                var products = _context
                                    .Products
                                    .Where(i=>i.IsApproved && (i.ProductName.ToLower().Contains(searchString.ToLower()) || 
                                                                i.Description.ToLower().Contains(searchString.ToLower())))
                                    .AsQueryable();
                return products.ToList();
            }
        }
    }
}