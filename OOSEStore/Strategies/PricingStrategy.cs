///////////////////////////////////////////////////////////
//  PricingStrategy.cs
//  Implementation of the Class PricingStrategy
//  Generated by Enterprise Architect
//  Created on:      04-Dec-2023 4:24:25 PM
//  Original author: User
///////////////////////////////////////////////////////////

using System.Xml;

using OOSEStore.Models;

namespace OOSEStore.Strategies
{
    public abstract class PricingStrategy
    {
        public decimal Value { get; internal set; }
        protected ProductTypes m_ProductType;
        protected SaleTypes m_SaleType;
        protected int LoyaltyPoints { get; set; }
        public PricingStrategy()
        {
            Value = decimal.MaxValue; //must override !!!
            LoyaltyPoints = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// 
        /// <param name="customer"></param>
        protected virtual int AddLoyalty(Customer customer) { return LoyaltyPoints; }

        /// <summary>
        /// 
        /// </summary>
        /// 
        /// <param name="transaction"></param>
        /// <param name="customer"></param>
        /// <param name="item"></param>
        public virtual decimal CalculatePrice(Transaction transaction, Customer customer, SaleItem item)
        {
            var newLoyaltyPoint = AddLoyalty(customer);
            customer.LoyaltyPoints += newLoyaltyPoint;
            var itemBasePrice = InternalCalculate(transaction, customer, item);
            Console.Write($"\tItems price: {itemBasePrice}");
            return itemBasePrice;
        }

        /// <summary>
        /// 
        /// </summary>
        /// 
        /// <param name="transaction"></param>
        /// <param name="customer"></param>
        /// <param name="item"></param>
        protected virtual decimal InternalCalculate(Transaction transaction, Customer customer, SaleItem item) { return Value; }

        public virtual void ToXml(XmlElement source)
        { //default there is nothing to print, the price will reflect on the receipt
        }

    }//end PricingStrategy

}//end namespace Store