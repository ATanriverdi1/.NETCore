using System.Collections.Generic;
using MarketingApp.Entity;

namespace MarketingApp.WebUI.ViewModel
{
    public class ProductDetailModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }

        public Comment Comment { get; set; }
        public List<Comment> Comments { get; set; }
    }
}