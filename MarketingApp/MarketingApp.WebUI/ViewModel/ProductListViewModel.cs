using System;
using System.Collections.Generic;
using MarketingApp.Entity;

namespace MarketingApp.WebUI.ViewModel
{
    public class PageInfo
    {
        //Toplam item
        public int TotalItems { get; set; }

        //Sayfa Başına düşen item
        public int ItemsPerPage { get; set; }

        //bulunduğumuz sayfa
        public int CurrentPage { get; set; }

        //Bulunduğumuz Kategori.
        public string CurrentCategory { get; set; }

        public int TotalPages()
        {
            return (int)Math.Ceiling((decimal)TotalItems/ItemsPerPage);
        }
    }
    
    public class ProductListViewModel
    {
        public PageInfo PageInfo { get; set; }
        public List<Product> Products { get; set; }
    }
}