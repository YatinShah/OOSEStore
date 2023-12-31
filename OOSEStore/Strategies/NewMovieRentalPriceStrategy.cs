///////////////////////////////////////////////////////////
//  MovieRentalPriceStrategy.cs
//  Implementation of the Class MovieRentalPriceStrategy
//  Generated by Enterprise Architect
//  Created on:      04-Dec-2023 4:24:25 PM
//  Original author: User
///////////////////////////////////////////////////////////

using OOSEStore.Models;

namespace OOSEStore.Strategies
{
    public class NewMovieRentalPriceStrategy : MovieRentalPriceStrategy
    {
        public NewMovieRentalPriceStrategy()
        {
            m_BaseValue = 3m;
            m_ProductType = ProductTypes.Movie;
            m_SaleType = SaleTypes.Rental;
        }
        protected override int AddLoyalty(Transaction transaction, Customer customer, SaleItem item)
        {
            var additionalLoyaltyPoints = 1;
            if (item.GetQuantity() > 1) return LoyaltyPoints + additionalLoyaltyPoints;
            return LoyaltyPoints;
        }

    }//end MovieRentalPriceStrategy

}//end namespace Store