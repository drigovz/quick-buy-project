using QuickBuy.Domain.Enums;

namespace QuickBuy.Domain.ValueObject
{
    public class PaymentOption
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsBankBillet
        {
            get { return Id == (int)TypePaymentOptionEnum.BankBillet; }
        }

        public bool IsCreditCard
        {
            get { return Id == (int)TypePaymentOptionEnum.CreditCard; }
        }

        public bool IsDeposit
        {
            get { return Id == (int)TypePaymentOptionEnum.Deposit; }
        }

        public bool IsUndefined
        {
            get { return Id == (int)TypePaymentOptionEnum.Undefined; }
        }
    }
}
