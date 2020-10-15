using System.ComponentModel.DataAnnotations;
using MarketingApp.WebUI.Models.Cart;

namespace MarketingApp.WebUI.Models.Order
{
    public class OrderModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        
        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }


        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        
        public CartModel CartModel { get; set; }
    }
}