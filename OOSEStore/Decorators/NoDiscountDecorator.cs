using OOSEStore.Models;
using OOSEStore.Strategies;

namespace OOSEStore.Decorators
{
    public class NoDiscountDecorator : CouponDecorator
    {
        public NoDiscountDecorator(PricingStrategy basePriceStrategy) : base(basePriceStrategy)
        {
        }
        protected override decimal CalculateDiscount(Transaction transaction, Customer customer, SaleItem item, decimal unitPrice)
        {
            return 0;
        }
    }
}
