﻿using OOSEStore.Models;
using OOSEStore.Strategies;

namespace OOSEStore.Decorators
{
    public class EarlyPromotionDiscountDecorator : CouponDecorator
    {

        public EarlyPromotionDiscountDecorator(PricingStrategy basePriceStrategy) : base(basePriceStrategy)
        {
            Value = 15m;
            IsItemDiscount = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// 
        /// <param name="transaction"></param>
        /// <param name="customer"></param>
        /// <param name="item"></param>
        protected override decimal CalculateDiscount(Transaction transaction, Customer customer, SaleItem item, decimal unitPrice)
        {
            return unitPrice * Value / 100;
        }


    }//end EarlyPromotionDiscount

}//end namespace Store