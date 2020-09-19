using System.Collections.Generic;
using MarketingApp.Entity;

namespace MarketingApp.WebUI.ViewModel.Admin
{
    public class AdminCategoryModel
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Url { get; set; }

        public List<Product> Products { get; set; }
    }
}