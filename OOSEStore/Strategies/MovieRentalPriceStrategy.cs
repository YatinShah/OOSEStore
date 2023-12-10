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
    public class MovieRentalPriceStrategy : RentalPricingStrategy
    {

        public MovieRentalPriceStrategy()
        {
            Value = 2m;
            m_ProductType = ProductTypes.Movie;
            m_SaleType = SaleTypes.Rental;
        }

    }//end MovieRentalPriceStrategy

}//end namespace Store