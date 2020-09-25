using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MarketingApp.Entity;

namespace MarketingApp.WebUI.ViewModel.Admin
{
    public class AdminProductModel
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage="Bu alan boş bırakılamaz.")]
        [StringLength(60,MinimumLength=5,ErrorMessage="5-60 karakter arasında olmalıdır.")]
        public string ProductName { get; set; }

        [Required(ErrorMessage="Bu alan boş bırakılamaz.")]
        [StringLength(20,MinimumLength=5,ErrorMessage="5-20 karakter arasında olmalıdır.")]
        public string Url { get; set; }

        [Required(ErrorMessage="Bu alan boş bırakılamaz.")]
        [Range(1,100000,ErrorMessage="1-100000 arasında bir değer giriniz.")]
        public double? ProductPrice { get; set; }

        [Required(ErrorMessage="Bu alan boş bırakılamaz.")]
        public string Description { get; set; }

        [Required(ErrorMessage="Bu alan boş bırakılamaz.")]
        public string ImageUrl { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHomePage { get; set; }

        public List<Category> SelectedCategories { get; set; }
    }
}