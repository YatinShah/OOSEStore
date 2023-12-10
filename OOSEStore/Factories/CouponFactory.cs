using OOSEStore.Decorators;
using OOSEStore.Models;

namespace OOSEStore.Factories
{
    public class CouponFactory
    {
        public CouponDecorator GetCoupon(CouponTypes coupon, Strategies.PricingStrategy pricingStrategy)
        {
            switch (coupon)
            {
                case CouponTypes.EarlyPromotion: return new EarlyPromotionDiscountDecorator(pricingStrategy);
                case CouponTypes.Loyalty: return new LoyaltyDiscountDecorator(pricingStrategy);
                case CouponTypes.Cart: return new CartDiscountDecorator(pricingStrategy);
                case CouponTypes.Percent: return new PercentDiscountDecorator(pricingStrategy);
                case CouponTypes.FreeItem: return new FreeItemDiscountDecorator(pricingStrategy);
                case CouponTypes.NoCoupon:
                default: return new NoDiscountDecorator(pricingStrategy);
            }
        }
    }
}
