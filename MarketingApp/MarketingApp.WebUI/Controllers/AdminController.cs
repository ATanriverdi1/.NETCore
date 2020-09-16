using MarketingApp.Business.Abstract;
using MarketingApp.Entity;
using MarketingApp.WebUI.Models;
using MarketingApp.WebUI.ViewModel;
using MarketingApp.WebUI.ViewModel.Admin;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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

        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(AdminProductModel adminProduct)
        {
            if (ModelState.IsValid)
            {
                var product = new Product()
                {
                    ProductName = adminProduct.ProductName,
                    Url=adminProduct.Url,
                    Description = adminProduct.Description,
                    ProductPrice = adminProduct.ProductPrice,
                    ImageUrl = adminProduct.ImageUrl
                };

                _productService.Create(product);

                var msg = new AlertMessage(){
                Message = $"{product.ProductName} isimli ürün eklendi.",
                AlertType = "success"
                };
                TempData["message"] = JsonConvert.SerializeObject(msg);

                return RedirectToAction("ProductList");    
            }

            return View(adminProduct);
        }

        [HttpGet]
        public IActionResult EditProduct(int? id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var entity = _productService.GetById((int)id);
            if (entity == null)
            {
                return NotFound();
            }

            var product = new AdminProductModel(){
                ProductId = entity.ProductId,
                ProductName = entity.ProductName,
                Url = entity.Url,
                Description = entity.Description,
                ProductPrice = entity.ProductPrice,
                ImageUrl = entity.ImageUrl
            };

            return View(product);
        }

        [HttpPost]
        public IActionResult EditProduct(AdminProductModel adminProduct)
        {
            var entity = _productService.GetById(adminProduct.ProductId);
            if (entity == null)
            {
                return NotFound();
            }
            entity.ProductName = adminProduct.ProductName;
            entity.Url = adminProduct.Url;
            entity.Description = adminProduct.Description;
            entity.ProductPrice = adminProduct.ProductPrice;
            entity.ImageUrl = adminProduct.ImageUrl;

            _productService.Update(entity);

            var msg = new AlertMessage(){
                Message = $"{entity.ProductName} isimli ürün güncellendi.",
                AlertType = "warning"
            };
            TempData["message"] = JsonConvert.SerializeObject(msg);
            return RedirectToAction("ProductList");
        }

        public IActionResult DeleteProduct(int productId)
        {
            var entity = _productService.GetById(productId);
            if (entity != null)
            {
                _productService.Delete(entity);
            }
            var msg = new AlertMessage(){
                Message = $"{entity.ProductName} isimli ürün kaldırıldı.",
                AlertType = "danger"
            };
            TempData["message"] = JsonConvert.SerializeObject(msg);
            return RedirectToAction("ProductList");
        }

        //Kategori işlemleri

              

    }
}