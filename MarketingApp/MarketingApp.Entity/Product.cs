using System.Collections.Generic;

namespace MarketingApp.Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Url { get; set; }
        public double? ProductPrice { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHomePage { get; set; }

        public List<ProductCategory> productCategories { get; set; }
        public List<Comment> Comments { get; set; }
    }
}