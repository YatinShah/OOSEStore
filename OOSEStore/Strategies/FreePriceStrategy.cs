///////////////////////////////////////////////////////////
//  DefaultRentalPriceStrategy.cs
//  Implementation of the Class DefaultRentalPriceStrategy
//  Generated by Enterprise Architect
//  Created on:      04-Dec-2023 4:24:25 PM
//  Original author: User
///////////////////////////////////////////////////////////

using OOSEStore.Models;

namespace OOSEStore.Strategies
{
    public class FreePriceStrategy : PricingStrategy
    {

        public FreePriceStrategy()
        {
            m_BaseValue = 0;//default rental price is 10 USD !!
            m_ProductType = ProductTypes.FreeItem;
            m_SaleType = SaleTypes.Free;

        }

    }//end DefaultRentalPriceStrategy

}//end namespace Store