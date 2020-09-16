using System;
using MarketingApp.Business.Abstract;
using MarketingApp.Data.Abstract;
using MarketingApp.WebUI.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace MarketingApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;
        public HomeController(IProductService productService)
        {
            this._productService = productService;
        }
        public IActionResult Index()
        {
            var productViewModel = new ProductListViewModel()
            {
                Products = _productService.GeProductstHomePage()
            };

            return View(productViewModel);
        }
    }
}