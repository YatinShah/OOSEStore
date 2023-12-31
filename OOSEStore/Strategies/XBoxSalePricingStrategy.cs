///////////////////////////////////////////////////////////
//  XBoxSalePricingStrategy.cs
//  Implementation of the Class XBoxSalePricingStrategy
//  Generated by Enterprise Architect
//  Created on:      04-Dec-2023 4:24:26 PM
//  Original author: User
///////////////////////////////////////////////////////////

using OOSEStore.Models;

namespace OOSEStore.Strategies
{
    public class XBoxSalePricingStrategy : SalePricingStrategy
    {

        public XBoxSalePricingStrategy()
        {
            m_BaseValue = 45m;
            m_ProductType = ProductTypes.XBox;
            m_SaleType = SaleTypes.Sale;

            LoyaltyPoints = 3;

        }

    }//end XBoxSalePricingStrategy

}//end namespace Store