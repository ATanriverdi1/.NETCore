using System;
using System.IO;
using MarketingApp.Business.Abstract;
using MarketingApp.Business.Concrete;
using MarketingApp.Data.Abstract;
using MarketingApp.Data.Concrete.EfCore;
using MarketingApp.WebUI.EmailServices;
using MarketingApp.WebUI.Models.identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;

namespace MarketingApp.WebUI
{
    public class Startup
    {
        private IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IProductRepository,EfCoreProductRepository>();
            services.AddScoped<IProductService,ProductManager>();

            services.AddScoped<ICategoryService,CategoryManager>();
            services.AddScoped<ICategoryRepository,EfCoreCategoryRepository>();

            services.AddScoped<ICartRepository,EfCoreCartRepository>();
            services.AddScoped<ICartService,CartManager>();

            services.AddScoped<ICommentRepository, EfCoreCommentRepository>();
            services.AddScoped<ICommentService, CommentManager>();

            services.AddScoped<IOrderRepository,EfCoreOrderRepository>();
            services.AddScoped<IOrderService, OrderManager>();
            
            //identity
            services.AddDbContext<ApplicationDbContext>(options=> options.UseSqlite("Data Source = Marketing.db"));
            services.AddIdentity<ApplicationUser,IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options=>{
                
                //Default Password settings.
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireNonAlphanumeric= false;
                options.Password.RequiredLength = 6;

                //Default Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;
                
                //Default Sign-in settings.
                options.SignIn.RequireConfirmedEmail = true;
                options.SignIn.RequireConfirmedPhoneNumber = false;

                //Default User settings.
                options.User.RequireUniqueEmail = true;
                options.User.AllowedUserNameCharacters =
                             "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
            });

            services.ConfigureApplicationCookie(options=>{
                //ReturnUrlParameter requires 
                options.LoginPath = "/account/login";
                options.LogoutPath = "/account/logout";
                options.AccessDeniedPath = "/account/accessdenied";
                
                options.SlidingExpiration = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                
                //CookieBuilder
                options.Cookie = new CookieBuilder{
                    Name = ".MarketingApp.Security.Cookie",
                    HttpOnly = true,
                    SameSite = SameSiteMode.Strict
                };   
            });

            services.AddScoped<IEmailSender,SmtpEmailSender>(i=> 
                new SmtpEmailSender(
                    _configuration["EmailSender:Host"],
                    _configuration.GetValue<int>("EmailSender:Port"),
                    _configuration.GetValue<bool>("EmailSender:EnableSSL"),
                    _configuration["EmailSender:UserName"],
                    _configuration["EmailSender:Password"])
                );
                
            //MVC
            services.AddControllersWithViews();
            services.AddMemoryCache();
            services.AddResponseCaching();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(  IApplicationBuilder app, 
                                IWebHostEnvironment env,
                                IConfiguration configuration,
                                UserManager<ApplicationUser> userManager, 
                                RoleManager<IdentityRole> roleManager)
        {
            app.UseStaticFiles(); //wwwroot
            app.UseResponseCaching();

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
            
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name:"orders",
                    pattern:"orders",
                    defaults: new {controller="Cart", action="GetOrders"}
                );

                endpoints.MapControllerRoute(
                    name:"cartcheckout",
                    pattern:"checkout",
                    defaults : new {controller="Cart", action="Checkout"}
                );

                //CartList
                endpoints.MapControllerRoute(
                    name:"cartindex",
                    pattern:"cart",
                    defaults : new {controller="Cart", action="Index"}
                );
                //Admin UserList
                endpoints.MapControllerRoute(
                    name:"adminuserlist",
                    pattern:"admin/user/list",
                    defaults : new {controller="admin", action="UserList"}
                );
                
                //Admin User Create
                endpoints.MapControllerRoute(
                    name:"adminusercreate",
                    pattern:"admin/user/create",
                    defaults : new {controller="admin", action="CreateUser"}
                );

                //Admin User Edit
                endpoints.MapControllerRoute(
                    name:"adminuseredit",
                    pattern:"admin/user/{id?}",
                    defaults : new {controller="admin", action="UserEdit"}
                );

                //Role List
                endpoints.MapControllerRoute(
                    name:"adminrolelist",
                    pattern:"admin/role/list",
                    defaults : new {controller="admin", action="RoleList"}
                );

                //AdminCreateRole
                endpoints.MapControllerRoute(
                    name:"admincreaterole",
                    pattern:"admin/role/create",
                    defaults : new {controller="admin", action="CreateRole"}
                );

                //AdminRoleEdit
                endpoints.MapControllerRoute(
                    name:"admincreaterole",
                    pattern:"admin/role/{id?}",
                    defaults : new {controller="admin", action="RoleEdit"}
                );

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
        
            
            SeedIdentity.Seed(userManager,roleManager,configuration).Wait();
        }
    }
}
