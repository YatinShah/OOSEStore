using OOSEStore.Models;
using OOSEStore.Strategies;

namespace OOSEStore.Factories
{
    public class PriceFreePricingFactory : PricingFactory
    {

        public override PricingStrategy GetPricingStrategy(SaleItem item)
        {
            return new FreePriceStrategy();
        }
    }//end PriceFreePricingFactory

}//end namespace Store