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
        public ICollection<OrderItem> Items { get; set; } = new Collection<OrderItem>();
    }
}
