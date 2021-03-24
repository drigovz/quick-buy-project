namespace QuickBuy.Domain.Entities
{
    public class OrderItem : BaseEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public override void Validate()
        {
            ClearMessageValidation();

            if (ProductId == 0)
                AddMessageValidation("Product reference not identified!");

            if (Quantity == 0)
                AddMessageValidation("Quantity shoul be mor than zero");
        }
    }
}
