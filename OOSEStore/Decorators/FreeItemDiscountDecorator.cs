///////////////////////////////////////////////////////////
//  FreeItemDiscount.cs
//  Implementation of the Class FreeItemDiscount
//  Generated by Enterprise Architect
//  Created on:      04-Dec-2023 4:24:25 PM
//  Original author: User
///////////////////////////////////////////////////////////

using System.Xml;

using OOSEStore.Models;
using OOSEStore.Strategies;
namespace OOSEStore.Decorators
{
    public class FreeItemDiscountDecorator : CouponDecorator
    {
        protected const int MINQTYFORDISCOUNT = 15;
        protected Product m_FreeProduct;
        private bool m_discountApplied;
        private SaleItem m_saleItem;

        public FreeItemDiscountDecorator(PricingStrategy basePriceStrategy) : base(basePriceStrategy)
        {
            Value = 1m;
            IsItemDiscount = false;
            m_FreeProduct = new Product(ProductTypes.Book);
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
            if (transaction.Purchases.Select(p => p.GetSaleType() != SaleTypes.Free).Count() > MINQTYFORDISCOUNT)
            {
                m_discountApplied = true;
                m_saleItem = new SaleItem(m_FreeProduct, 1, SaleTypes.Free);
                transaction.AddProduct(m_saleItem, customer);
            }
            return 0;
        }

        public override void ToXml(XmlElement source)
        {
            if (!m_discountApplied) return;
            XmlElement element = source.OwnerDocument.CreateElement("FreeDiscount");
            XmlElement freeItem = source.OwnerDocument.CreateElement("FreeItem");
            freeItem.SetAttribute("_", $"{m_saleItem.GetProductType()} Item added to purchases.");
            element.AppendChild(freeItem);
            source.AppendChild(element);
        }

    }//end FreeItemDiscount

}//end namespace Store