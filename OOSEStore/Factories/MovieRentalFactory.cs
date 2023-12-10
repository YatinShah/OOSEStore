using OOSEStore.Models;
using OOSEStore.Strategies;

namespace OOSEStore.Factories
{
    public class MovieRentalFactory
    {
        public PricingStrategy GetMovieRentalStrategy(ProductSubTypes subType)
        {
            switch (subType)
            {
                case ProductSubTypes.New: return new NewMovieRentalPriceStrategy();
                case ProductSubTypes.Children: return new ChildrenMovieRentalPriceStrategy();
                default: return new MovieRentalPriceStrategy();
            }
        }
    }
}
