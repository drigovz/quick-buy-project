using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace QuickBuy.Domain.Entities
{
    public class User : BaseEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Order> Orders { get; set; } = new Collection<Order>();

        public override void Validate()
        {
            ClearMessageValidation();

            if (string.IsNullOrEmpty(Email))
                AddMessageValidation("Email shouldn't be empty!");

            if (string.IsNullOrEmpty(Password))
                AddMessageValidation("Password shouldn't be empty!");

            if (Password.Length < 5)
                AddMessageValidation("Password should be more than 5 chars!");

            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(FirstName))
                AddMessageValidation("First Name and Last Name shouldn't be empty!");
        }
    }
}
