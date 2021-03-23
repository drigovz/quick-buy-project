using QuickBuy.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace QuickBuy.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public DateTime DateDelivery { get; set; }
        public string CEP { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int Number { get; set; }
        public int PaymentOptionId { get; set; }
        public PaymentOption PaymentOption { get; set; }
        public ICollection<OrderItem> Items { get; set; } = new Collection<OrderItem>();
    }
}
