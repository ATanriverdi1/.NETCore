using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MarketingApp.Entity;

namespace MarketingApp.WebUI.ViewModel.Admin
{
    public class AdminCategoryModel
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage="Bu alan boş bırakılamaz.")]
        [StringLength(20,MinimumLength=5,ErrorMessage="5-20 karakter arasında olmalıdır.")]
        public string CategoryName { get; set; }

        [Required(ErrorMessage="Bu alan boş bırakılamaz.")]
        [StringLength(20,MinimumLength=5,ErrorMessage="5-20 karakter arasında olmalıdır.")]
        public string Url { get; set; }

        public List<Product> Products { get; set; }
    }
}