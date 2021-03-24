namespace QuickBuy.Domain.Entities
{
    public class Product : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Name))
                AddMessageValidation("Name shouldn't be empty!");

            if (Name.Length < 2)
                AddMessageValidation("Password should be more than 2 chars!");

            if (Price < 0)
                AddMessageValidation("Price not valid!");
        }
    }
}
