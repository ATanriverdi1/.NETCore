using System.Collections.Generic;
using MarketingApp.Entity;

namespace MarketingApp.WebUI.Models
{
    public class ProductDetailModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}