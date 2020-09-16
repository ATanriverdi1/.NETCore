using System.Linq;
using MarketingApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace MarketingApp.Data.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new MarketingContext();
            
            if(context.Database.GetPendingMigrations().Count()==0)
            {
                if (context.Categories.Count()==0)
                {
                    context.Categories.AddRange(Categories);
                }

                if (context.Products.Count()==0)
                {
                    context.Products.AddRange(Products);
                    context.AddRange(productCategories);
                }
            }
            context.SaveChanges();
        }

        private static Category[] Categories = {
            new Category() {CategoryName = "Telefon", Url="telefon"},
            new Category() {CategoryName = "Bilgisayar", Url="bilgisayar"},
            new Category() {CategoryName = "Elektronik", Url="elektronik"},
            new Category() {CategoryName = "Beyaz Eşya", Url="beyaz-esya"}
        };

        private static Product[] Products = {
            new Product() {ProductName = "Iphone 6",Url="Iphone-6", ProductPrice = 2000, Description = "Güzel Telefon", ImageUrl="Iphone.png", IsApproved = true, IsHomePage = false},
            new Product() {ProductName = "Iphone 7",Url="Iphone-7", ProductPrice = 3000, Description = "Sağlam Telefon", ImageUrl="Iphone2.png", IsApproved = true, IsHomePage = false},
            new Product() {ProductName = "Iphone 8",Url="Iphone-8", ProductPrice = 4000, Description = "Sağlam Telefon", ImageUrl="Iphone3.png", IsApproved = true, IsHomePage = true},
            new Product() {ProductName = "Iphone X",Url="Iphone-x", ProductPrice = 5000, Description = "Güzel Telefon", ImageUrl="Iphone4.png", IsApproved = true, IsHomePage = false},
            new Product() {ProductName = "Iphone 11",Url="Iphone-11", ProductPrice = 6000, Description = "Güzel Telefon", ImageUrl="Iphone5.png", IsApproved = true, IsHomePage = false},
            new Product() {ProductName = "Asus Tuf Gaming",Url="asus-tuf-gaming", ProductPrice = 10000, Description = "Oyun Bilgisayarı", ImageUrl="Asus.png", IsApproved = true, IsHomePage = true},
            new Product() {ProductName = "Xiaomi AirDots",Url="xiaomi-airdots", ProductPrice = 600, Description = "bluetooth kulaklık", ImageUrl="AirDots.png", IsApproved = true, IsHomePage = true}
        };

        private static ProductCategory[] productCategories ={
            new ProductCategory(){Product=Products[0], Category= Categories[0]},
            new ProductCategory(){Product=Products[0], Category= Categories[2]},
            new ProductCategory(){Product=Products[1], Category= Categories[0]},
            new ProductCategory(){Product=Products[1], Category= Categories[2]},
            new ProductCategory(){Product=Products[2], Category= Categories[0]},
            new ProductCategory(){Product=Products[2], Category= Categories[2]},
            new ProductCategory(){Product=Products[3], Category= Categories[0]},
            new ProductCategory(){Product=Products[3], Category= Categories[2]},
            new ProductCategory(){Product=Products[4], Category= Categories[0]},
            new ProductCategory(){Product=Products[4], Category= Categories[2]},
            new ProductCategory(){Product=Products[5], Category= Categories[1]},
            new ProductCategory(){Product=Products[5], Category= Categories[2]},
            new ProductCategory(){Product=Products[6], Category= Categories[2]}
        };
    }
}