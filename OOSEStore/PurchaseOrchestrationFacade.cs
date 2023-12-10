using System.Xml;

using OOSEStore.Models;

namespace OOSEStore
{
    public class PurchaseOrchestrationFacade
    {
        private readonly Customer m_Customer;
        private readonly Transaction m_Transaction;

        public PurchaseOrchestrationFacade(Customer acustomer)
        {
            m_Customer = acustomer;
            m_Transaction = m_Customer.CheckOut("Christmas Purchases");
        }
        public void BuyItems()
        {
            //purchasing 4 items, 
            m_Transaction.AddProduct(new SaleItem(new Product(ProductTypes.MusicCD), 3, SaleTypes.Sale), m_Customer);
            m_Transaction.AddProduct(new SaleItem(new Product(ProductTypes.XBox), 1, SaleTypes.Sale), m_Customer, CouponTypes.EarlyPromotion);
            m_Transaction.AddProduct(new SaleItem(new Product(ProductTypes.Ps4), 1, SaleTypes.Sale), m_Customer, CouponTypes.EarlyPromotion);
            m_Transaction.AddProduct(new SaleItem(new Product(ProductTypes.Book), 10, SaleTypes.Sale), m_Customer, CouponTypes.EarlyPromotion);
        }

        public void RentItems()
        {
            //Renting 2 items
            m_Transaction.AddProduct(new SaleItem(new Product(ProductTypes.VideoGame), 5, SaleTypes.Rental), m_Customer, CouponTypes.Percent);
            m_Transaction.AddProduct(new SaleItem(new Product(ProductTypes.Movie), 1, SaleTypes.Rental), m_Customer, CouponTypes.Percent);
        }

        internal void AddCartCoupons()
        {
            //additional coupons applicable at cart level, (Not at item level!!
            m_Transaction.AddCoupon(m_Customer, CouponTypes.Loyalty);
            m_Transaction.AddCoupon(m_Customer, CouponTypes.Cart);
            m_Transaction.AddCoupon(m_Customer, CouponTypes.FreeItem);
        }
        internal void GetStoreManagerGift()
        {
            //Adding a free item, aka store keepers gift !!
            m_Transaction.AddProduct(new SaleItem(new Product(ProductTypes.FreeItem), 10, SaleTypes.Free), m_Customer, CouponTypes.NoCoupon);
        }

        internal void GenerateXmlReceipt()
        {
            var xmlDoc = new XmlDocument();
            var docElement = xmlDoc.CreateElement(name: "Purchases");
            docElement.SetAttribute("Customer", m_Customer.Name);
            docElement.SetAttribute("LoyaltyPoints", m_Customer.LoyaltyPoints.ToString());
            m_Transaction.ToXml(docElement);
            xmlDoc.AppendChild(docElement);

            File.WriteAllTextAsync("receipt.xml", xmlDoc.OuterXml);
        }
    }
}
