namespace OOSEStore
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var customer = new Customer("Yatin Shah");

            var purchasing = new PurchaseOrchestrationFacade(customer);

            purchasing.BuyItems();
            purchasing.GetStoreManagerGift();
            purchasing.RentItems();
            purchasing.AddCartCoupons();

            purchasing.GenerateXmlReceipt();
        }
    }
}
