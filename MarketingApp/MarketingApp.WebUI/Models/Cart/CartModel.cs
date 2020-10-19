using System.Collections.Generic;
using System.Linq;

namespace MarketingApp.WebUI.Models.Cart
{
    public class CartModel
    {
        public int CartId { get; set; }
        public List<CartItemModel> CartItemModels { get; set; }

        public double TotalPrice(){
            return CartItemModels.Sum(i=>i.Price * i.Quantity);
        }
    }

    public class CartItemModel
    {
        public int CartItemId { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public int Quantity { get; set; }
    }
}