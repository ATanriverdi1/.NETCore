using System.IO;
using MarketingApp.Business.Abstract;
using MarketingApp.Business.Concrete;
using MarketingApp.Data.Abstract;
using MarketingApp.Data.Concrete.EfCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;

namespace MarketingApp.WebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IProductRepository,EfCoreProductRepository>();
            services.AddScoped<IProductService,ProductManager>();

            services.AddScoped<ICategoryService,CategoryManager>();
            services.AddScoped<ICategoryRepository,EfCoreCategoryRepository>();
            
            //MVC
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles(); //wwwroot

            app.UseStaticFiles(new StaticFileOptions{
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(),"node_modules")),
                    RequestPath="/modules"
            });

            if (env.IsDevelopment())
            {
                SeedDatabase.Seed();
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //AdminCreateCategoryUrl
                endpoints.MapControllerRoute(
                    name:"admincreatecategory",
                    pattern:"admin/kategori-ekle",
                    defaults: new {controller="admin", action="CreateCategory"}
                );
                
                //AdminCategoryList Url
                endpoints.MapControllerRoute(
                    name:"admincategorylist",
                    pattern:"admin/kategoriler",
                    defaults: new {controller="admin", action="CategoryList"}
                );

                //AdminEditCategory Url
                endpoints.MapControllerRoute(
                    name:"admineditcategory",
                    pattern:"admin/kategoriler/{id?}",
                    defaults: new {controller="admin", action="EditCategory"}
                );

                //AdminCreateProductUrl
                endpoints.MapControllerRoute(
                    name:"admincreateproduct",
                    pattern:"admin/ürün-ekle",
                    defaults: new {controller="admin", action="CreateProduct"}
                );
                //AdminProducListtUrl
                endpoints.MapControllerRoute(
                    name:"adminproductlist",
                    pattern:"admin/ürünler",
                    defaults: new {controller="admin", action="ProductList"}
                );
                
                //AdminEditProduct Url
                endpoints.MapControllerRoute(
                    name:"adminproductlist",
                    pattern:"admin/ürünler/{id?}",
                    defaults: new {controller="admin", action="EditProduct"}
                );

                //HomePage Url
                endpoints.MapControllerRoute(
                    name:"HomePage",
                    pattern:"Anasayfa",
                    defaults: new {controller="Home", action="Index"}
                );

                //Shop/Search Url
                endpoints.MapControllerRoute(
                    name:"search",
                    pattern:"search",
                    defaults: new {controller="shop", action="search"}
                );
                

                //ProductDetail Url
                endpoints.MapControllerRoute(
                    name:"productDetail",
                    pattern:"{url}",
                    defaults: new {controller="shop", action="details"}
                );
                //ProductListByCategory Url
                endpoints.MapControllerRoute(
                    name:"products",
                    pattern:"ürünler/{category?}",
                    defaults: new {controller="shop", action="list"}
                );

                //Default RouteConfing
               endpoints.MapControllerRoute(
                   name:"default",
                   pattern:"{controller=Home}/{action=Index}/{id?}"
               );
            });
        }
    }
}
