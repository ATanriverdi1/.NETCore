using System.Collections.Generic;
using MarketingApp.Entity;

namespace MarketingApp.WebUI.ViewModel.Admin
{
    public class AdminProductModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Url { get; set; }
        public double ProductPrice { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHomePage { get; set; }

        public List<Category> SelectedCategories { get; set; }
    }
}