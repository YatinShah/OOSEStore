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
    public class VideoGameRentalPriceStrategy : RentalPricingStrategy
    {

        public VideoGameRentalPriceStrategy()
        {
            m_BaseValue = 6m;
            m_ProductType = ProductTypes.VideoGame;
            m_SaleType = SaleTypes.Rental;

            LoyaltyPoints = 2;

        }

    }//end VideoGameRentalPriceStrategy

}//end namespace Store