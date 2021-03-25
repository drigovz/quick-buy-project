using Microsoft.EntityFrameworkCore;
using QuickBuy.Domain.Entities;
using QuickBuy.Domain.ValueObject;

namespace QuickBuy.Repository.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrdersItens { get; set; }
        public DbSet<PaymentOption> PaymentOptions { get; set; }
    }
}
