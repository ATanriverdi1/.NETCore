using MarketingApp.Business.Abstract;
using MarketingApp.WebUI.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace MarketingApp.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private IProductService _productService;
        public AdminController(IProductService productService)
        {
            this._productService = productService;
        }
        public IActionResult ProductList()
        {
            var productListViewModel = new ProductListViewModel()
            {
                Products = _productService.GetAll()
            };
            return View(productListViewModel);
        }
    }
}