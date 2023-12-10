///////////////////////////////////////////////////////////
//  XBoxRentalPriceStrategy.cs
//  Implementation of the Class XBoxRentalPriceStrategy
//  Generated by Enterprise Architect
//  Created on:      04-Dec-2023 4:24:26 PM
//  Original author: User
///////////////////////////////////////////////////////////

using OOSEStore.Models;

namespace OOSEStore.Strategies
{
    public class XBoxRentalPriceStrategy : RentalPricingStrategy
    {

        public XBoxRentalPriceStrategy()
        {
            Value = 6m;
            m_ProductType = ProductTypes.XBox;
            m_SaleType = SaleTypes.Rental;

            LoyaltyPoints = 3;

        }

    }//end XBoxRentalPriceStrategy

}//end namespace Store