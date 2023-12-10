///////////////////////////////////////////////////////////
//  SaleItem.cs
//  Implementation of the Class SaleItem
//  Generated by Enterprise Architect
//  Created on:      04-Dec-2023 4:24:26 PM
//  Original author: User
///////////////////////////////////////////////////////////

using System.Xml;

namespace OOSEStore.Models
{
    public class SaleItem
    {

        public decimal SalePrice { get; set; }
        public SaleTypes m_SaleTypes;
        public Product? m_Product;
        private readonly int m_qty;

        public SaleItem(Product? product, int qty, SaleTypes saleType)
        {
            m_Product = product;
            m_qty = qty;
            m_SaleTypes = saleType;
        }

        public ProductTypes GetProductType() { return m_Product?.m_ProductTypes ?? ProductTypes.Book; }

        public SaleTypes GetSaleType() { return m_SaleTypes; }
        public int GetQuantity() { return m_qty; }
        public ProductSubTypes GetProductSubType()
        {
            return m_Product?.m_ProductSubTypes ?? ProductSubTypes.None;
        }

        public decimal GetCost()
        {
            return m_SaleTypes == SaleTypes.Rental ? SalePrice : SalePrice * m_qty;
        }
        public void ToXml(XmlElement source)
        {
            XmlElement element = source.OwnerDocument.CreateElement("Item");
            element.SetAttribute("SaleType", m_SaleTypes.ToString());
            element.SetAttribute(m_SaleTypes == SaleTypes.Rental ? "RentalDays" : "Quantity", m_qty.ToString());
            m_Product?.ToXml(element);

            element.SetAttribute("Price", SalePrice.ToString("C"));
            element.SetAttribute("Cost", GetCost().ToString("C"));
            source.AppendChild(element);
        }

    }//end SaleItem

}//end namespace Store