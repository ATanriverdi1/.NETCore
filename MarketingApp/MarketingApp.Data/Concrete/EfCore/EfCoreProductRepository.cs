using System.Collections.Generic;
using System.Linq;
using MarketingApp.Data.Abstract;
using MarketingApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace MarketingApp.Data.Concrete.EfCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product, MarketingContext>, IProductRepository
    {
        public void Create(Product entity, int[] categoryIds)
        {
            using (var context = new MarketingContext())
            {
                
                if (entity != null)
                {
                    var product = new Product(){
                    ProductName = entity.ProductName,
                    Description = entity.Description,
                    ProductPrice = entity.ProductPrice,
                    ImageUrl = entity.ImageUrl,
                    Url = entity.Url,
                    IsApproved = entity.IsApproved,
                    IsHomePage = entity.IsHomePage,
                    };

                    entity.productCategories = categoryIds.Select(catid=> new ProductCategory(){
                        ProductId = entity.ProductId,
                        CategoryId = catid
                    }).ToList();
                    
                    context.Add(entity);
                    context.SaveChanges();
                }
                
            }
        }

        public List<Product> GeProductstHomePage()
        {
            using (var context = new MarketingContext()) 
            {
                return context.Products.Where(i=>i.IsApproved && i.IsHomePage).ToList();
            }
        }

        public Product GetByIdWithCategory(int productId)
        {
            using (var context = new MarketingContext())
            {
                return context.Products
                            .Where(p=>p.ProductId == productId)
                            .Include(pc => pc.productCategories)
                            .ThenInclude(c=>c.Category)
                            .FirstOrDefault();
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

        public void Update(Product entity, int[] categoryIds)
        {
            using (var context = new MarketingContext())
            {
                var product = context.Products
                                    .Include(pc=>pc.productCategories)
                                    .FirstOrDefault(i=>i.ProductId == entity.ProductId);

                if (product != null)
                {
                    product.ProductName = entity.ProductName;
                    product.Url = entity.Url;
                    product.Description = entity.Description;
                    product.ProductPrice = entity.ProductPrice;
                    product.ImageUrl = entity.ImageUrl;
                    product.IsHomePage = entity.IsHomePage;
                    product.IsApproved = entity.IsApproved;

                    product.productCategories = categoryIds.Select(catid=> new ProductCategory()
                    {
                        CategoryId = catid,
                        ProductId = entity.ProductId
                    }).ToList();

                    context.SaveChanges();
                }
            }
        }
    }
}