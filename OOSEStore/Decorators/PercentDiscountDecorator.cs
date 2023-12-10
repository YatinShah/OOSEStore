///////////////////////////////////////////////////////////
//  PercentDiscount.cs
//  Implementation of the Class PercentDiscount
//  Generated by Enterprise Architect
//  Created on:      04-Dec-2023 4:24:25 PM
//  Original author: User
///////////////////////////////////////////////////////////

using OOSEStore.Models;
using OOSEStore.Strategies;
namespace OOSEStore.Decorators
{
    public class PercentDiscountDecorator : CouponDecorator
    {

        public PercentDiscountDecorator(PricingStrategy basePriceStrategy) : base(basePriceStrategy)
        {
            m_BaseValue = 20m;
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
            return unitPrice * m_BaseValue / 100;
        }


    }//end PercentDiscount

}//end namespace Store