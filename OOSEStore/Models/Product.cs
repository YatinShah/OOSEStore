///////////////////////////////////////////////////////////
//  Product.cs
//  Implementation of the Class Product
//  Generated by Enterprise Architect
//  Created on:      04-Dec-2023 4:24:25 PM
//  Original author: User
///////////////////////////////////////////////////////////

using System.Xml;

namespace OOSEStore.Models
{
    public class Product
    {

        public bool IsPriceFree = false;
        public ProductTypes m_ProductTypes;

        public Product(ProductTypes productType)
        {
            m_ProductTypes = productType;

        }

        public void ToXml(XmlElement source)
        {
            source.SetAttribute("ProductType", m_ProductTypes.ToString());
        }


    }//end Product

}//end namespace Store