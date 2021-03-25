using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Domain.ValueObject;

namespace QuickBuy.Repository.Config
{
    public class PaymentOptionConfiguration : IEntityTypeConfiguration<PaymentOption>
    {
        public void Configure(EntityTypeBuilder<PaymentOption> builder)
        {
        }
    }
}
