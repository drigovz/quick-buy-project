﻿using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace QuickBuy.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Order> Orders { get; set; } = new Collection<Order>();
    }
}