using System;
using System.Collections.Generic;

namespace MarketingApp.Entity
{
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string UserId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public string PaymentId { get; set; }
        public string ConversationId { get; set; }
        
        public EnumPaymentType PaymentType { get; set; }
        public EnumOrderStat OrderStat { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }

    public enum EnumPaymentType
    {
        CreditCard = 0,
        Eft = 1
    }
    public enum EnumOrderStat
    {
        waiting = 0,
        unpaid = 1,
        completed = 2
    }
}