using System.Collections.Generic;

namespace MarketingApp.Entity
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Url { get; set; }

        public List<ProductCategory> productCategories { get; set; }
    }
}