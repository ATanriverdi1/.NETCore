using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MarketingApp.Business.Abstract;
using MarketingApp.Entity;
using MarketingApp.WebUI.Models;
using MarketingApp.WebUI.ViewModel;
using MarketingApp.WebUI.ViewModel.Admin;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MarketingApp.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private ICategoryService _categoryService;
        private IProductService _productService;

        public AdminController(IProductService productService, ICategoryService categoryService)
        {
            this._productService = productService;
            this._categoryService = categoryService;
        }

        //ProductList
        public IActionResult ProductList()
        {
            var productListViewModel = new ProductListViewModel()
            {
                Products = _productService.GetAll()
            };
            return View(productListViewModel);
        }

        //CreateProduct
        [HttpGet]
        public IActionResult CreateProduct()
        {
            ViewBag.Categories = _categoryService.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(AdminProductModel adminProduct, int[] categoryIds)
        {
            if (ModelState.IsValid)
            {   
                var product = new Product()
                {
                    ProductName = adminProduct.ProductName,
                    Url=adminProduct.Url,
                    Description = adminProduct.Description,
                    ProductPrice = adminProduct.ProductPrice,
                    ImageUrl = adminProduct.ImageUrl,
                    IsHomePage = adminProduct.IsHomePage,
                    IsApproved = adminProduct.IsApproved
                };
                
                _productService.Create(product, categoryIds);

                var msg = new AlertMessage(){
                Message = $"{product.ProductName} isimli ürün eklendi.",
                AlertType = "success"
                };
                TempData["message"] = JsonConvert.SerializeObject(msg);

                return RedirectToAction("ProductList");    
            }

            ViewBag.Categories = _categoryService.GetAll();
            return View(adminProduct);
        }

        //EditProduct
        [HttpGet]
        public IActionResult EditProduct(int? id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var entity = _productService.GetByIdWithCategory((int)id);
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
                IsApproved = entity.IsApproved,
                IsHomePage = entity.IsHomePage,
                ImageUrl = entity.ImageUrl,
                SelectedCategories = entity.productCategories.Select(c=>c.Category).ToList()
            };

            ViewBag.Categories = _categoryService.GetAll();

            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> EditProduct(AdminProductModel adminProduct, int[] categoryIds, IFormFile file)
        {
            if (ModelState.IsValid)
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
                entity.IsApproved = adminProduct.IsApproved;
                entity.IsHomePage = adminProduct.IsHomePage;

                if (file!=null)
                {
                    var extention = Path.GetExtension(file.FileName);
                    var randomName = string.Format($"{DateTime.Now.Ticks}{extention}");
                    entity.ImageUrl = randomName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot\\images",randomName);

                    using (var stream = new FileStream(path,FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }

                _productService.Update(entity,categoryIds);

                var msg = new AlertMessage(){
                    Message = $"{entity.ProductName} isimli ürün güncellendi.",
                    AlertType = "warning"
                };
                TempData["message"] = JsonConvert.SerializeObject(msg);
                return RedirectToAction("ProductList");
            }
            
            ViewBag.Categories=_categoryService.GetAll();
            
            return View(adminProduct);    
        }

        //DeleteProduct
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

        //Categori List
        public IActionResult CategoryList()
        {
            var categories = new CategoryViewModel(){
                Categories = _categoryService.GetAll()
            };
            return View(categories);
        }

        //Create Category
        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(AdminCategoryModel adminCategoryModel)
        {
            if (ModelState.IsValid)
            {
                var category = new Category()
                {
                    CategoryName = adminCategoryModel.CategoryName,
                    Url = adminCategoryModel.Url
                };
                
                _categoryService.Create(category);

                var msg = new AlertMessage()
                {
                    Message = $"{category.CategoryName} isimli kategori eklendi.",
                    AlertType = "success"
                };
                TempData["message"] = JsonConvert.SerializeObject(msg);

                return RedirectToAction("CategoryList");
            }

            return View(adminCategoryModel);
        }      

        //Edit Category
        [HttpGet]
        public IActionResult EditCategory(int? id)
        {
            if (id == null)
                return NotFound();
            
            var entity = _categoryService.GetByIdWithProduct((int)id);
            
            if(entity == null)
                return NotFound();
            
            var category = new AdminCategoryModel(){
                CategoryId = entity.CategoryId,
                CategoryName = entity.CategoryName,
                Url = entity.Url,
                Products = entity.productCategories.Select(p=>p.Product).ToList()
            };

            return View(category);
        }

        [HttpPost]
        public IActionResult EditCategory(AdminCategoryModel adminCategoryModel)
        {
            if (ModelState.IsValid)
            {
                var entity = _categoryService.GetById(adminCategoryModel.CategoryId);
            
                if(entity == null)
                    return NotFound();

                entity.CategoryId = adminCategoryModel.CategoryId;
                entity.CategoryName = adminCategoryModel.CategoryName;
                entity.Url = adminCategoryModel.Url;

                _categoryService.Update(entity);

                var msg = new AlertMessage(){
                    Message = $"{entity.CategoryName} isimli kategori güncellendi.",
                    AlertType = "warning"
                };

                TempData["message"] = JsonConvert.SerializeObject(msg);

                return RedirectToAction("CategoryList");    
            }

            return View(adminCategoryModel);
        }   

        //Delete Category
        public IActionResult DeleteCategory(int categoryId)
        {
            var entity = _categoryService.GetById(categoryId);
            if (entity != null)
            {
                _categoryService.Delete(entity);
            }

            var msg = new AlertMessage(){
                Message = $"{entity.CategoryName} isimli ürün kaldırıldı.",
                AlertType = "danger"
            };
            TempData["message"] = JsonConvert.SerializeObject(msg);
            return RedirectToAction("CategoryList");    
        }

        //DeleteProductFromCategory
        [HttpPost]
        public IActionResult DeleteProductFromCategory(int productId, int categoryId)
        {
            _categoryService.DeleteProductFromCategory(productId,categoryId);
            return Redirect("/admin/kategoriler/"+@categoryId);
        }
    }
}