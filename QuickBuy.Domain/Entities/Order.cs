using QuickBuy.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace QuickBuy.Domain.Entities
{
    public class Order : BaseEntity
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

        public override void Validate()
        {
            ClearMessageValidation();

            if (!Items.Any())
                AddMessageValidation("Order cannot run out of order items!");

            if (string.IsNullOrEmpty(CEP))
                AddMessageValidation("CEP must be defined");

            if (PaymentOptionId == 0)
                AddMessageValidation("Payment option must be informed");
        }
    }
}
