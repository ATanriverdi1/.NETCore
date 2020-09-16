using System.Linq;
using MarketingApp.Business.Abstract;
using MarketingApp.Entity;
using MarketingApp.WebUI.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace MarketingApp.WebUI.Controllers
{
    public class ShopController:Controller
    {
        private IProductService _productService;

        public ShopController(IProductService productService)
        {
            this._productService = productService;
        }

        public IActionResult List(string category, int page = 1)
        {
            const int pageSize = 3;
            var Products = new ProductListViewModel()
            {
                PageInfo = new PageInfo(){
                    TotalItems = _productService.GetCountByCategory(category),
                    CurrentPage = page,
                    CurrentCategory = category,
                    ItemsPerPage = pageSize
                },
                Products = _productService.GetProductsByCategory(category, page, pageSize)
            };
            return View(Products);
        }

        public IActionResult Details(string url)
        {
            if (url == null)
                return NotFound();

            Product product = _productService.GetProductDetails(url);

            if(product == null)
                return NotFound();

            return View(new ProductDetailModel{
                Product = product,
                Categories = product.productCategories.Select(i=> i.Category).ToList()
            });
        }

        public IActionResult Search(string q)
        {
            if (!string.IsNullOrEmpty(q))
            {
                var productViewModel= new ProductListViewModel()
                {
                    Products = _productService.GetSearchResult(q)
                };

                return View(productViewModel);    
            }
            return RedirectToAction("list");
        }       
    }
}